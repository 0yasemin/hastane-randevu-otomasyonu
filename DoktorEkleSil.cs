using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace HastaneRandevuOtomasyonu
{
    public partial class DoktorEkleSil : Form
    {
        public DoktorEkleSil()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoktorEkleSil_Load(object sender, EventArgs e)  // Form ilk yüklendiğinde (açıldığında) çalışan olay metodu.
        {
            Doktorgoster();  // Form yüklendiğinde 'Doktorgoster()' metodunu çağırarak doktor verilerini DataGridView'e yükler.

            // Klinik verilerini ComboBox'a yükleme

            SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT klinikID, klinikAdi FROM klinik", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt); // DataAdapter ile çekilen veriler DataTable'a doldurulur.
            comboBoxKlinik.DataSource = dt;  // ComboBox'ın veri kaynağı olarak doldurulan DataTable atanır.
            comboBoxKlinik.DisplayMember = "klinikAdi"; // Kullanıcıya görünen
            comboBoxKlinik.ValueMember = "klinikID";    // Veritabanına gidecek
        }

        private void adminGeri_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmAdminEkrani.Show();
            this.Hide();
        }

        void Doktorgoster()  // Veritabanındaki Doktor bilgilerini DataGridView'de göstermek için kullanılan özel metot.
        {

            SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

            SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT d.doktorID, 
               d.doktorAdiSoyadi, 
               d.klinikID,             -- eklendi (comboBox için lazım)
               k.klinikAdi, 
               d.kullanciAdi, 
               d.sifre
        FROM doktor d
        INNER JOIN klinik k ON d.klinikID = k.klinikID", baglanti); // 'doktor' ve 'klinik' tablolarını birleştirerek doktor bilgilerini ve bağlı oldukları klinik adını çeken SQL sorgusu.

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // klinikID sütununu gizle (gerekli ama kullanıcı görmesin)
            if (dataGridView1.Columns.Count > 2) // DataGridView'de en az 3 sütun olduğundan emin olur (0, 1, 2. indeksler).
            {
                dataGridView1.Columns[2].Visible = false; // 2.indeksdeki(klinikID) sütununu gizler.
            }

            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {  //metin kutuları boş mu?? kontrol
            if (!string.IsNullOrWhiteSpace(txtDoktorId.Text) &&
                !string.IsNullOrWhiteSpace(txtDoktorAdS.Text) &&
                !string.IsNullOrWhiteSpace(txtKullaniciAd.Text) &&
                !string.IsNullOrWhiteSpace(txtDSifre.Text))
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
                {
                    try
                    {
                        baglanti.Open();
                        string sorgu = "INSERT INTO doktor(doktorID, doktorAdiSoyadi, klinikID, kullanciAdi, sifre) " +
                                       "VALUES (@did, @dAdiSoyadi, @dklinikid, @kadi, @sifre)";
                        using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                        {
                            komut.Parameters.AddWithValue("@did", txtDoktorId.Text);
                            komut.Parameters.AddWithValue("@dAdiSoyadi", txtDoktorAdS.Text);
                            komut.Parameters.AddWithValue("@dklinikid", comboBoxKlinik.SelectedValue);
                            komut.Parameters.AddWithValue("@kadi", txtKullaniciAd.Text);
                            komut.Parameters.AddWithValue("@sifre", txtDSifre.Text);
                            komut.ExecuteNonQuery();
                        }

                        MessageBox.Show("Yeni doktor başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Temizleme
                        txtDoktorId.Clear();
                        txtDoktorAdS.Clear();
                        txtKullaniciAd.Clear();
                        txtDSifre.Clear();
                        comboBoxKlinik.SelectedIndex = 0;  // ComboBox'ı ilk öğeye getirir.

                        Doktorgoster(); // Doktorları yenile
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)  // DataGridView'de seçili bir satır olup olmadığını kontrol eder.
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // Seçili satırdaki ilk hücreden(doktorID) değeri alır.

                SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
                SqlCommand komut = new SqlCommand("DELETE FROM doktor WHERE doktorID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Doktor silindi.");
                Doktorgoster(); // listeyi yenile
            }
            else
            {
                MessageBox.Show("Lütfen bir doktor seç.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)  // DataGridView'deki bir hücreye tıklandığında çalışan olay metodu.
        {

            if (e.RowIndex >= 0)  // Geçerli bir satır indeksine tıklandığından emin olur.
            {
                txtDoktorId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();  // doktorID
                txtDoktorAdS.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); // doktorAdiSoyadi
                comboBoxKlinik.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value;  // klinikID (Gizli sütundaki değer)
                txtKullaniciAd.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); // kullanciAdi
                txtDSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();      // sifre
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // DataGridView'de seçili bir satır olup olmadığını kontrol eder.
            {
                string id = txtDoktorId.Text;  // Güncellenecek doktorun ID'sini metin kutusundan alır.

                SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
                SqlCommand komut = new SqlCommand("UPDATE doktor SET doktorAdiSoyadi=@adsoyad, klinikID=@klinik, kullanciAdi=@kadi, sifre=@sifre WHERE doktorID=@id", baglanti);
                komut.Parameters.AddWithValue("@adsoyad", txtDoktorAdS.Text);
                komut.Parameters.AddWithValue("@klinik", comboBoxKlinik.SelectedValue);
                komut.Parameters.AddWithValue("@kadi", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@sifre", txtDSifre.Text);
                komut.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Doktor bilgileri güncellendi.");
                Doktorgoster(); // tabloyu yenile

                // Temizleme işlemleri
                txtDoktorId.Clear();
                txtDoktorAdS.Clear();
                txtKullaniciAd.Clear();
                txtDSifre.Clear();
                if (comboBoxKlinik.Items.Count > 0)  // ComboBox'ta öğe varsa ilk öğeyi seçer
                    comboBoxKlinik.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Lütfen bir doktor seç.");
            }
        }

        private void comboBoxKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
