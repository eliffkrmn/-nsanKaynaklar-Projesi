using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.DAL
{
    public class baglantiGetir
    {
        public MySqlConnection BaglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430025;User=26_132430025;Password=İnif123.;");
            baglanti.Open();
            return baglanti;
        }

        public async Task<MySqlConnection> BaglantiGetirAsync()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430025;User=26_132430025;Password=İnif123.;");
            await baglanti.OpenAsync();
            return baglanti;
        }
    }
}