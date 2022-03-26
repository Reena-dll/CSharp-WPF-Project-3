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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfPersonel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void chcBeniHatirla_Click(object sender, RoutedEventArgs e)
        {
           
        }
        void BeniHatirla()
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand cmd = new SqlCommand("Select * from BeniHatirla", cNutusic.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["username"].ToString() != "sifir" || dr["password"].ToString() != "sifir")
                    {
                        txtUsername.Text = dr["username"].ToString();
                        txtPassword.Password = dr["password"].ToString();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Warning);
                throw;
            }
            finally
            {
                cNutusic.con.Close();
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BeniHatirla();
            chcBeniHatirla.IsChecked = false;

        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (txtUsername.Text.Trim() != "" && txtPassword.Password.Trim() != "")
            {

                cNutusic.baglantiKontrol();
                SqlCommand cmd2 = new SqlCommand("select * from Personeller where KullaniciAdi=@p1 and Sifre=@p2 and Durum=1 ", cNutusic.con);
                cmd2.Parameters.AddWithValue("@p1", txtUsername.Text);
                cmd2.Parameters.AddWithValue("@p2", txtPassword.Password);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    if (chcBeniHatirla.IsChecked==true)
                    {
                        try
                        {
                            cNutusic.baglantiKontrol();
                            SqlCommand cmd = new SqlCommand("Update BeniHatirla set username=@p1, password=@p2 where id=1", cNutusic.con);
                            cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@p2", txtPassword.Password);
                            cmd.ExecuteNonQuery();

                        }
                        catch (SqlException ex)
                        {
                            string hata = ex.Message;
                            MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);

                        }
                        finally
                        {
                            cNutusic.con.Close();

                        }
                    }
                   
               

                    Menu mn = new Menu();
                    mn.AktifKullanici = txtUsername.Text;
                    mn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı...!!", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtUsername.Text = "";
                    txtPassword.Password = "";
                }


            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre Alanlarını Doldurunuz...!", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtUsername.Text = "";
                txtPassword.Password = "";
            }
        }
    

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Uygulamayı Kapatmak İstiyor Musunuz ?", "Bilgilendirme Penceresi", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void TextBlock_Clicked(object sender, MouseButtonEventArgs e)
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand cmd = new SqlCommand("Update BeniHatirla set username='sifir', password='sifir' where id=1", cNutusic.con);

                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            finally
            {

                cNutusic.con.Close();
                MessageBox.Show("Beni Hatırla Bilgileriniz Sıfırlanmıştır.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                txtUsername.Text = "";
                txtPassword.Password = "";
            }
        }

    }
}

