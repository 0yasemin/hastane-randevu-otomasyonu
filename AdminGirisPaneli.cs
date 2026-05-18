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
    public partial class AdminGirisPaneli : Form
    {
        public AdminGirisPaneli()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminGeri_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmAnaEkran.Show(); // anaekran formunu gösterir
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtBoxKadi.Text) || string.IsNullOrWhiteSpace(txtBoxKsifre.Text)) // Kullanıcı adı veya şifre metin kutularının boş olup olmadığını kontrol eder.
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = bgl.Baglanti())
                {
                    string query = "SELECT * FROM admin WHERE kullaniciAdi=@kadi AND sifre=@sifre";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@kadi", txtBoxKadi.Text);
                    komut.Parameters.AddWithValue("@sifre", txtBoxKsifre.Text);

                    SqlDataAdapter da = new SqlDataAdapter(komut); // SQL sorgusunun sonuçlarını bir veri adaptörüne yükler.
                    DataTable dt = new DataTable();  // Veri adaptöründen gelen verileri tutmak için boş bir DataTable oluşturur.
                    da.Fill(dt); // Veri adaptöründeki verileri DataTable'a doldurur.

                    if (dt.Rows.Count > 0) //eşleşen bir kullanıcı bulunduysa
                    {
                        new AdminEkrani().Show();
                        txtBoxKadi.Clear();
                        txtBoxKsifre.Clear();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtBoxKsifre_TextChanged(object sender, EventArgs e)
        {

              txtBoxKsifre.PasswordChar = '*';
        }

        private void AdminGirisPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}