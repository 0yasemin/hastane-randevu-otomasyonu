using static System.Windows.Forms.DataFormats;

namespace HastaneRandevuOtomasyonu
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }



        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //çýkýþ- uygulamayý kapatma
        }

        private void AnaAdminGiris_Click(object sender, EventArgs e)
        {
            Formlar.frmAdminGirisPaneli.Show(); // Formlar clasýnda tanýmladýðýmýz frmAdminGirisPaneli formumuzu göstertiyoruz.
            this.Hide(); // Mevcut Ana Ekran formunu gizler.
        }

        private void AnaHastaGiris_Click(object sender, EventArgs e)
        {
            Formlar.frmHastaGirisPaneli.Show();
            this.Hide();
        }

        private void AnaDoktorGiris_Click(object sender, EventArgs e)
        {
            Formlar.frmDoktorGirisPaneli.Show();
            this.Hide();
        }

        private void AnaEkran_Load_1(object sender, EventArgs e)
        {

        }
    }
}
