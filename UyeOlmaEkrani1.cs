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
    public partial class UyeOlmaEkrani1 : Form
    {
        public UyeOlmaEkrani1()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmHastaGirisPaneli.Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text.Trim();  // txtTc metin kutusundaki T.C. kimlik numarası değerini alır ve başındaki/sonundaki boşlukları temizler.

            if (tc.Length != 11 || tc == "00000000000")  //tc geçerliliği kontrol -11 hane mi -
            {
                MessageBox.Show("Geçerli bir T.C. Kimlik Numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO Hasta (TCno, ad, soyad, sifre, anneAd, babaAd, dogumTarihi, cinsiyet, telNo, ePosta) " +
                                   "VALUES (@tc, @ad, @soyad, @sifre, @anneAd, @babaAd, @dogumTarihi, @cinsiyet, @telNo, @ePosta)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@tc", txtTc.Text.Trim());
                        komut.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                        komut.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                        komut.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                        komut.Parameters.AddWithValue("@anneAd", txtAnneAd.Text.Trim());
                        komut.Parameters.AddWithValue("@babaAd", txtBabaAd.Text.Trim());
                        komut.Parameters.AddWithValue("@dogumTarihi", dtDogumTarihi.Value);
                        komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text.Trim());
                        komut.Parameters.AddWithValue("@telNo", txtTelNo.Text.Trim());
                        komut.Parameters.AddWithValue("@ePosta", txtEposta.Text.Trim());

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarıyla üye olundunuz.'RANDEVU AL' butonuna tıklayarak randevunuzu alabilirsiniz.");

                    KutulariTemizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KutulariTemizle()
        {
            txtTc.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtSifre.Clear();
            txtAnneAd.Clear();
            txtBabaAd.Clear();
            txtCinsiyet.Clear();
            txtTelNo.Clear();
            txtEposta.Clear();
            dtDogumTarihi.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmRandevuAlmaPaneli.Show();
            this.Hide();
        }

        private void UyeOlmaEkrani1_Load(object sender, EventArgs e)
        {

        }
    }
}
