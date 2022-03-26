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
    /// Interaction logic for Giderler.xaml
    /// </summary>
    public partial class Giderler : Window
    {
        public Giderler()
        {
            InitializeComponent();
        }

        public string AktifKullanici;

        void Giderlerr()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Giderler order by ID asc", cNutusic.con);
            da.Fill(dt);
            MyGrid.ItemsSource = dt.DefaultView;

            cmbYıl.Items.Add("2019");
            cmbYıl.Items.Add("2020");
            cmbYıl.Items.Add("2021");
            cmbYıl.Items.Add("2022");
            cmbYıl.Items.Add("2023");
            cmbYıl.Items.Add("2024");

            cmbAy.Items.Add("Ocak");
            cmbAy.Items.Add("Şubat");
            cmbAy.Items.Add("Mart");
            cmbAy.Items.Add("Nisan");
            cmbAy.Items.Add("Mayıs");
            cmbAy.Items.Add("Haziran");
            cmbAy.Items.Add("Temmuz");
            cmbAy.Items.Add("Ağustos");
            cmbAy.Items.Add("Eylül");
            cmbAy.Items.Add("Ekim");
            cmbAy.Items.Add("Kasım");
            cmbAy.Items.Add("Aralık");
        }

        void Temizle()
        {
            txtID.Text = "";
            cmbAy.Text = "";
            cmbYıl.Text = "";
            txtElektrik.Text = "0";
            txtSu.Text = "0";
            txtInternet.Text = "0";
            txtDogalgaz.Text = "0";
            txtEkstra.Text = "0";
            txtMaas.Text = "0";
            rchNotlar.Document.Blocks.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Giderlerr();
            Temizle();


        }
        private void btnGeriGel_Click(object sender, RoutedEventArgs e)
        {
            Menu fr = new Menu();
            fr.AktifKullanici = AktifKullanici;
            fr.Show();
            this.Close();
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand komut = new SqlCommand("insert into Giderler (Ay,Yil,Elektrik,Su,Dogalgaz,Internet,Maaslar,Ekstra,Notlar) values " +
                   "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", cNutusic.con);
                komut.Parameters.AddWithValue("@p1", cmbAy.Text);
                komut.Parameters.AddWithValue("@p2", cmbYıl.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(txtMaas.Text));
                komut.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
                string richText = new TextRange(rchNotlar.Document.ContentStart, rchNotlar.Document.ContentEnd).Text;
                komut.Parameters.AddWithValue("@p9", richText);
                komut.ExecuteNonQuery();
                cNutusic.con.Close();
                MessageBox.Show("Gider Kayıt İşleminiz Başarıyla Gerçekleşti", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            finally
            {
                Giderlerr();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand komut = new SqlCommand("update Giderler set Ay=@p1,Yil=@p2,Elektrik=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Maaslar=@p7,Ekstra=@p8,Notlar=@p9 where " +
                    "ID=@p10", cNutusic.con);
                komut.Parameters.AddWithValue("@p1", cmbAy.Text);
                komut.Parameters.AddWithValue("@p2", cmbYıl.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(txtMaas.Text));
                komut.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
                string richText = new TextRange(rchNotlar.Document.ContentStart, rchNotlar.Document.ContentEnd).Text;
                komut.Parameters.AddWithValue("@p9", richText);
                komut.Parameters.AddWithValue("@p10", txtID.Text);
                komut.ExecuteNonQuery();
                cNutusic.con.Close();
                MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleştirildi.", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {

                Temizle();
                Giderlerr();
            }
        }

        private void btnTemizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

      

        private void cmbAy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void MyGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                cmbAy.Text = row_selected["Ay"].ToString();
                cmbYıl.Text = row_selected["Yil"].ToString();
                txtDogalgaz.Text = row_selected["Dogalgaz"].ToString();
                txtEkstra.Text = row_selected["Ekstra"].ToString();
                txtInternet.Text = row_selected["Internet"].ToString();
                txtMaas.Text = row_selected["Maaslar"].ToString();
                txtSu.Text = row_selected["Su"].ToString();
                txtID.Text = row_selected["ID"].ToString();
                txtElektrik.Text = row_selected["Elektrik"].ToString();
                rchNotlar.Document.Blocks.Clear();
                rchNotlar.Document.Blocks.Add(new Paragraph(new Run(row_selected["Notlar"].ToString())));
            }
        }
    }
}
