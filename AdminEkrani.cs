using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuOtomasyonu
{
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //burası sayfa yönlendirme 
        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmAdminEkleSil.Show();
            this.Hide();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmDoktorEkleSil.Show();
            this.Hide();
        }

        private void btnKlinikEkle_Click(object sender, EventArgs e)
        {
            HastaneRandevuOtomasyonu.Formlar.frmKlinikEkleSil.Show();
            this.Hide();
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
