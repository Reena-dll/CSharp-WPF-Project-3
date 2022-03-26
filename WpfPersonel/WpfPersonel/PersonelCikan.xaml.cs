using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WpfPersonel
{
    /// <summary>
    /// Interaction logic for PersonelCikan.xaml
    /// </summary>
    public partial class PersonelCikan : Window
    {
        public PersonelCikan()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

        }

        void Listele()
        {
            cNutusic.baglantiKontrol();
            SqlDataAdapter da = new SqlDataAdapter("exec PersonelListeCikan", cNutusic.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MyGrid.ItemsSource = dt.DefaultView;
        }

        void Temizle()
        {
            txtPersonelID.Text = "";
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        private void MyGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtPersonelID.Text = row_selected["PersonelID"].ToString();
                txtPersonelAd.Text = row_selected["PersonelAd"].ToString();
                txtPersonelSoyad.Text = row_selected["PersonelSoyad"].ToString();

            }
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand cmd = new SqlCommand("update Personeller set Durum=1 where PersonelID=@p1", cNutusic.con);
                cmd.Parameters.AddWithValue("@p1", txtPersonelID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Personeliniz Yeniden İşe Alındı.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch
            {
                MessageBox.Show("Ağ Hatası. Bağlantı İşlemi Gerçekleştirilemedi.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            finally
            {
                Listele();
                Temizle();
                Personeller.personel.Listele();
                Personeller.personel.Temizle();

            }
        }
    }
}
