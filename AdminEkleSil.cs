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
    public partial class AdminEkleSil : Form
    {
        public AdminEkleSil()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();


        private void adminGeri_Click(object sender, EventArgs e)
        {

            HastaneRandevuOtomasyonu.Formlar.frmAdminEkrani.Show(); 
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void goster() // Veritabanındaki Admin bilgilerini DataGridView'de göstermek için kullanılan özel metot.
        {
            SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

            SqlDataAdapter da = new SqlDataAdapter("select *from Admin", baglanti);
            DataTable dt = new DataTable();  // Verileri depolamak için boş bir DataTable oluşturulur.
            da.Fill(dt); // DataAdapter ile çekilen veriler DataTable'a doldurulur.
            dataGridView1.DataSource = dt; //doldurulan veriler DataTable atanır, veriler görüntülenir.
            baglanti.Close();
        }

        private void AdminEkleSil_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //kutular boş mu kontrol 
            if (string.IsNullOrWhiteSpace(txtAdminTC.Text) ||
                string.IsNullOrWhiteSpace(txtAdminAd.Text) ||
                string.IsNullOrWhiteSpace(txtAdminSifre.Text))
            {
                MessageBox.Show("Boş giriş yapılmaz");
                return;
            }

            try
            {
                using (SqlConnection baglanti = bgl.Baglanti()) 
                {
                    string sorgu = "INSERT INTO Admin (adminID, kullaniciAdi, sifre) VALUES (@adminID, @kullaniciAdi, @sifre)";
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adminID", int.Parse(txtAdminTC.Text));
                        komut.Parameters.AddWithValue("@kullaniciAdi", txtAdminAd.Text);
                        komut.Parameters.AddWithValue("@sifre", txtAdminSifre.Text);

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Yeni admin başarıyla eklendi.");
                txtAdminTC.Clear();
                txtAdminAd.Clear();
                txtAdminSifre.Clear();
                goster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAdminTC.Text != "") // Silinecek Admin TC'si girilmiş mi kontrol eder.
            {
                try
                {
                    SqlConnection baglanti = bgl.Baglanti();
                    SqlCommand komut = new SqlCommand("DELETE FROM Admin WHERE adminID = @id", baglanti);
                    komut.Parameters.AddWithValue("@id", txtAdminTC.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Admin başarıyla silindi.");
                    txtAdminTC.Clear();
                    txtAdminAd.Clear();
                    txtAdminSifre.Clear();
                    goster();   // DataGridView'i güncel verilerle yeniden doldurur.
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek admin TC'sini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdminTC.Text != "" && txtAdminAd.Text != "" && txtAdminSifre.Text != "")   // Gerekli metin kutularının dolu olup olmadığını kontrol eder.
            {
                try
                {
                    SqlConnection baglanti = bgl.Baglanti();
                    SqlCommand komut = new SqlCommand("UPDATE Admin SET kullaniciAdi = @ad, sifre = @sifre WHERE adminID = @id", baglanti);
                    komut.Parameters.AddWithValue("@ad", txtAdminAd.Text);
                    komut.Parameters.AddWithValue("@sifre", txtAdminSifre.Text);
                    komut.Parameters.AddWithValue("@id", txtAdminTC.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Admin bilgileri başarıyla güncellendi.");
                    txtAdminTC.Clear();
                    txtAdminAd.Clear();
                    txtAdminSifre.Clear();
                    goster();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
