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
    public partial class RandevuAlmaPaneli : Form
    {
        public RandevuAlmaPaneli()
        {
            InitializeComponent();
            txtRandevuNo.Enabled = false;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmHastaGirisPaneli.Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtRandevuNo_TextChanged(object sender, EventArgs e)
        {

        }


        public static string tckimlik;   // Hastanın TC kimlik numarasını statik olarak tutan değişken. Bu, farklı formlar arasında TC bilgisinin taşınmasını sağlar.
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

            if (txtTc.Text != "")
            {
                tckimlik = txtTc.Text;

                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO Randevu(doktorID, klinikID, TCno, tarih, saat, tarihVeSaat) " +
                                   "VALUES(@rdid, @rkid, @tc, @tarih, @saat, @tarihVeSaat)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@rdid", cbDrAd.SelectedValue);
                    komut.Parameters.AddWithValue("@rkid", cbKlinik.SelectedValue);
                    komut.Parameters.AddWithValue("@tc", tckimlik);
                    komut.Parameters.AddWithValue("@tarih", dateTimeRandevuTarih.Value);
                    komut.Parameters.AddWithValue("@saat", cbRandevuSaat.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@tarihVeSaat",
                        dateTimeRandevuTarih.Value.ToShortDateString() + "-" + cbRandevuSaat.SelectedItem.ToString() +
                        " Doktoru: " + cbDrAd.SelectedValue);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Randevu Alınmıştır.");
                    baglanti.Close();
                    txtTc.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bu doktora ait randevulardan bu tarih doludur. Lütfen başka bir tarih seçiniz!!!",
                                    "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("TC Kimlik Numarası Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtRandevuNo.Clear();
            txtRandevuNo.Focus();
        }

        private void btnRandevuIptal_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmRandevuIptal.Show(); 
            this.Hide();
        }
        

        private void RandevuAlmaPaneli_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

            // Klinik verilerini ComboBox'a yükleme

            baglanti.Open();
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("select * from klinik", baglanti);
            da.Fill(dt);   // DataAdapter ile çekilen veriler DataTable'a doldurulur.
            cbKlinik.ValueMember = "klinikID";   
            cbKlinik.DisplayMember = "klinikAdi";  
            cbKlinik.DataSource = dt;    // ComboBox'ın veri kaynağı olarak doldurulan DataTable atanır

            baglanti.Close();
        }

        private void cbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            try
            {
                baglanti.Open();
                SqlCommand doktor = new SqlCommand("SELECT doktorID, doktorAdiSoyadi FROM doktor WHERE klinikID = @kid", baglanti);
                doktor.Parameters.AddWithValue("@kid", cbKlinik.SelectedValue);   // Seçilen kliniğin ID'sini parametre olarak ekler


                SqlDataAdapter da = new SqlDataAdapter(doktor);  // Doktor sorgusunun sonuçlarını bir veri adaptörüne yükler
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbDrAd.DisplayMember = "doktorAdiSoyadi";
                cbDrAd.ValueMember = "doktorID";
                cbDrAd.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RandevuAlmaPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }
    }
}
