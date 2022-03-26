using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Input;
using System.Windows;


namespace WpfPersonel
{
    class cNutusic
    {
        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=YusufTaha;Integrated Security=True; MultipleActiveResultSets=True");

        public static void baglantiKontrol()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show("Veri Tabanı Bağlantısı Yapılamadı", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Warning);
                    Application.Current.Shutdown();

                }

            }
        }
    }
}
