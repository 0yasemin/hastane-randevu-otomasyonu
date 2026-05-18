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
    public partial class HastaGirisPaneli : Form
    {
        public HastaGirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmAnaEkran.Show();
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtHastaTC.Text) || string.IsNullOrWhiteSpace(txtHastaSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = bgl.Baglanti())
                {
                    string query = "SELECT * FROM Hasta WHERE TCno=@tcno AND sifre=@sifre";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@tcno", txtHastaTC.Text);
                    komut.Parameters.AddWithValue("@sifre", txtHastaSifre.Text);

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    if (dt.Rows.Count > 0) // Eğer DataTable'da bir veya daha fazla satır varsa (yani, eşleşen bir hasta bulunduysa). 
                    {

                        new RandevuAlmaPaneli().Show();
                        txtHastaTC.Clear();
                        txtHastaSifre.Clear();
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

        private void button4_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmUyeOlmaEkrani.Show();
            this.Hide(); 
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HastaGirisPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
