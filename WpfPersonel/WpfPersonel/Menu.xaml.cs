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

namespace WpfPersonel
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        public string AktifKullanici;
        string adsoyad = "";

        void SayfaDuzen()
        {

            cNutusic.baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select PersonelAd,PersonelSoyad,PersonelRutbe.Rutbe,KullaniciAdi,Sifre from Personeller inner join PersonelRutbe on PersonelRutbe.RutbeID=Personeller.Rutbe where KullaniciAdi=@p1", cNutusic.con);
            cmd.Parameters.AddWithValue("@p1", AktifKullanici);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (dr["Rutbe"].ToString() == "Patron" || dr["Rutbe"].ToString() == "Müdür" || dr["Rutbe"].ToString() == "Müdür Yardımcısı" || dr["Rutbe"].ToString() == "Sekreter")
                {
                    btnPersoneller.IsEnabled = true;
                    btnGiderler.IsEnabled = true;
                    
                    btnMusteriler.IsEnabled = true;
                    

                    lblAktifKullanici.Content = (dr["PersonelAd"] + " " + dr["PersonelSoyad"] + " // " + dr["Rutbe"] + " // Yetki Sınırsız").ToString();
                }
                else
                {
                    btnPersoneller.IsEnabled = false;
                    btnGiderler.IsEnabled = false;
                    
                    btnMusteriler.IsEnabled = false;

                    lblAktifKullanici.Content = (dr["PersonelAd"] + " " + dr["PersonelSoyad"] + " // " + dr["Rutbe"] + " // Yetki Sınırlı").ToString();
                }
                adsoyad = (dr["PersonelAd"] + " " + dr["PersonelSoyad"]).ToString();

                label3.Content = "Hoş Geldiniz " + (dr["PersonelAd"] + " " + dr["PersonelSoyad"]).ToString();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           SayfaDuzen();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Uygulamayı Kapatmak İstiyor Musunuz ?", "Bilgilendirme Penceresi", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void btnPersoneller_Click(object sender, RoutedEventArgs e)
        {
            Personeller pr = new Personeller();
            pr.AktifKullanici = AktifKullanici;
            pr.Show();
            this.Hide();
        }

        private void btnGiderler_Click(object sender, RoutedEventArgs e)
        {
            Giderler gr = new Giderler();
            gr.AktifKullanici = AktifKullanici;
            gr.Show();
            this.Hide();
        }

        private void btnMusteriler_Click(object sender, RoutedEventArgs e)
        {
            Musteriler mr = new Musteriler();
            mr.AktifKullanici = AktifKullanici;
            mr.Show();
            this.Hide();
        }

        private void btnRecete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
