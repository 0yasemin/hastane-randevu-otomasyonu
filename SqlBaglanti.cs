using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;


namespace HastaneRandevuOtomasyonu
{
    internal class SqlBaglanti
    {
        // Bağlantı dizesi (connection string)

        private readonly string baglantiString = @"Data Source=monster;Initial Catalog=HastaneRandevuVT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        // 'baglantiString' adında, veritabanı bağlantı bilgilerini içeren bir değişken.



        // SQL bağlantısını açıp döndüren metot
        public SqlConnection Baglanti()  // 'Baglanti' adında, 'SqlConnection' tipinde bir nesne döndüren public bir metot.
        {
            SqlConnection baglanti = new SqlConnection(baglantiString);
            baglanti.Open();
            return baglanti;
        }
    }
}
