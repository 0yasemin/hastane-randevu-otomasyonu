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



namespace HastaneRandevuOtomasyonu
{
    public partial class KlinikEkleSil : Form
    {
        public KlinikEkleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        private void txtKlinikId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKlinikAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminGeri_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmAdminEkrani.Show(); 
            this.Hide(); 
        }

        private void KlinikEkleSil_Load(object sender, EventArgs e)
        {
            KlinikListele();
        }

        private void KlinikListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM klinik", baglanti);
            DataTable dt = new DataTable(); // Verileri depolamak için boş bir DataTable oluşturulur.
            da.Fill(dt);  //doldurulur
            dataGridView1.DataSource = dt; //atama, görüntüleme
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO klinik (klinikAdi) VALUES (@ad)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtKlinikAd.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();   // Sorguyu çalıştırır (INSERT işlemi).
            baglanti.Close();

            MessageBox.Show("Klinik eklendi.");
            KlinikListele(); // DataGridView'i güncel verilerle yeniden doldurur.
            txtKlinikAd.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM klinik WHERE klinikID=@id", baglanti);
            komut.Parameters.AddWithValue("@id", txtKlinikId.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Klinik silindi.");
            KlinikListele();
            txtKlinikId.Clear();
            txtKlinikAd.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE klinik SET klinikAdi=@ad WHERE klinikID=@id", baglanti);
            komut.Parameters.AddWithValue("@ad", txtKlinikAd.Text);
            komut.Parameters.AddWithValue("@id", txtKlinikId.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Klinik güncellendi.");
            KlinikListele();
            txtKlinikId.Clear();
            txtKlinikAd.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // DataGridView'deki bir hücreye tıklandığında çalışan olay metodu.
        {
            if (e.RowIndex >= 0)  // Geçerli bir satır indeksine tıklandığından emin olma
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex]; // Tıklanan satırı alır
                txtKlinikId.Text = satir.Cells["klinikID"].Value.ToString();  // Tıklanan satırdaki "klinikID" sütunundaki değeri txtKlinikId metin kutusuna atar.
                txtKlinikAd.Text = satir.Cells["klinikAdi"].Value.ToString();
            }






        }
    }
}
