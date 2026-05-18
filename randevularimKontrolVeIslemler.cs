using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneRandevuOtomasyonu
{
    public partial class randevularimKontrolVeIslemler : Form
    {


        private readonly string connectionString = "Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public randevularimKontrolVeIslemler()
        {
            InitializeComponent();

            // DataGridView ayarları 
            dataGridView1.ReadOnly = true;  // DataGridView'deki hücrelerin düzenlenmesini engeller.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Kullanıcının tüm satırı seçebilmesini sağlar.
            dataGridView1.AllowUserToAddRows = false;  // Kullanıcının DataGridView'e yeni satır eklemesini engeller.
            dataGridView1.AllowUserToDeleteRows = false;  // Kullanıcının DataGridView'den satır silmesini engeller.
            txtRandevuNo.Enabled = false;
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmRandevuAlmaPaneli.Show(); 
            this.Hide();
        }

        private void btnRandevuIptal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)  // DataGridView'de hiç satır seçili olup olmadığını kontrol eder.
            {
                MessageBox.Show("Lütfen iptal etmek için randevu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili satırdan 'randevuID' değerini alır
            int randevuID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["randevuID"].Value);

            // Kullanıcıdan onay alma
            var onay = MessageBox.Show($"Randevu ID: {randevuID} olan randevuyu iptal etmek istediğinizden emin misiniz?", "Randevu İptali Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                  
                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        baglanti.Open(); 

                        SqlCommand cmd = new SqlCommand("DELETE FROM Randevu WHERE randevuID = @id", baglanti);
                        cmd.Parameters.AddWithValue("@id", randevuID);
                        int sonuc = cmd.ExecuteNonQuery(); // Sorguyu çalıştır

                        if (sonuc > 0)  // Eğer bir veya daha fazla satır etkilendiyse
                        {
                            MessageBox.Show("Randevu başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            btnAra_Click(null, null);  //yenile formu
                        }
                        else
                        {
                            MessageBox.Show("Randevu bulunamadı veya zaten iptal edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Randevu iptal edilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text.Trim();

            // TC Kimlik Numarası kontrolü
            if (tc.Length != 11)
            {
                MessageBox.Show("Lütfen 11 haneli TC Kimlik Numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.DataSource = null; 
                return;
            }

            try
            {
                
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();

                    // SQL sorgusu: 'Randevu', 'Doktor' ve 'Klinik' tablolarını JOIN yaparak, belirtilen TC Kimlik Numarasına ait randevuları getirir

                    string sorgu = @"SELECT R.randevuID, D.doktorAdiSoyadi, K.klinikAdi, R.tarih, R.saat
                                     FROM Randevu R
                                     JOIN Doktor D ON R.doktorID = D.doktorID
                                     JOIN klinik K ON R.klinikID = K.klinikID
                                     WHERE R.TCno = @tc";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@tc", tc); // TC parametresini ekle sorguya

                    DataTable dt = new DataTable();
                    da.Fill(dt); 

                    if (dt.Rows.Count > 0)  // Eğer DataTable'da veri varsa (randevu bulunduysa).
                    {
                        dataGridView1.DataSource = dt; // DataGridView'e verileri bağla
                    }
                    else
                    {
                        dataGridView1.DataSource = null; 
                        MessageBox.Show("Belirtilen TC Kimlik Numarasına ait randevu bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular aranırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void randevularimKontrolVeIslemler_Load(object sender, EventArgs e)
        {

        }
    }
}
