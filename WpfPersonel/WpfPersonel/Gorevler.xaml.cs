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
    /// Interaction logic for Gorevler.xaml
    /// </summary>
    public partial class Gorevler : Window
    {
        public Gorevler()
        {
            InitializeComponent();
        }

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select RutbeID,Rutbe from PersonelRutbe", cNutusic.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MyGrid.ItemsSource = dt.DefaultView;
        }

        void Temizle()
        {
            txtGorevAd.Text = "";
            txtGorevID.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Listele();
        }

        private void MyGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtGorevAd.Text = row_selected["Rutbe"].ToString();
                txtGorevID.Text = row_selected["RutbeID"].ToString();

            }
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand cmd = new SqlCommand("insert into PersonelRutbe (Rutbe) values (@p1)", cNutusic.con);
                cmd.Parameters.AddWithValue("@p1", txtGorevAd.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Görev Ekleme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Listele();
                Temizle();
                cNutusic.con.Close();
                Personeller.personel.Listele();
                Personeller.personel.Temizle();

            }
        }

        private void btnTemizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            if (txtGorevID.Text == "1" || txtGorevID.Text == "2" || txtGorevID.Text == "3" || txtGorevID.Text == "10")
            {
                MessageBox.Show("Dokunulmazlığı Olan Kategori. Yetkililer Değiştirilemez. Hata Kodu 2", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    cNutusic.baglantiKontrol();
                    SqlCommand cmd = new SqlCommand("update PersonelRutbe set Rutbe=@p1 where RutbeID=@p2", cNutusic.con);
                    cmd.Parameters.AddWithValue("@p1", txtGorevAd.Text);
                    cmd.Parameters.AddWithValue("@p2", txtGorevID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Görev Güncelleme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    Listele();
                    Temizle();
                    cNutusic.con.Close();
                    Personeller.personel.Listele();
                    Personeller.personel.Temizle();

                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
