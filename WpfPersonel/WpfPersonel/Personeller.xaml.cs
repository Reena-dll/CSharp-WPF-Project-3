using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
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
    /// Interaction logic for Personeller.xaml
    /// </summary>
    public partial class Personeller : Window
    {
        public Personeller()
        {
            InitializeComponent();
        }

        public string AktifKullanici;
        public static Personeller personel;

        public void Temizle()
        {
            txtPersonelID.Text = "";
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelTelefon.Text = "";
            txtTC.Text = "";
            txtMail.Text = "";
            cmbSehir.Text = "Seçiniz";
            cmbIlce.Text = "Seçiniz";
            cmbGorev.Text = "Seçiniz";
            rchAdres.Document.Blocks.Clear();
            txtKullaniciAdi.Text = "";
            txtKullaniciSifre.Text = "";
        }

        void Toplamisci()
        {
            cNutusic.baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select count(*) from personeller where Durum=1", cNutusic.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblCalisanSayi.Text = dr[0].ToString();
            }
            cNutusic.con.Close();
        }

        void istenAyrilan()
        {
            cNutusic.baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select count(*) from personeller where Durum=0", cNutusic.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblistencikan.Text = dr[0].ToString();
            }
            cNutusic.con.Close();
        }

        void Sehirler()
        {
            cNutusic.baglantiKontrol();
            SqlDataAdapter da = new SqlDataAdapter("select * from Sehirler", cNutusic.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSehir.DisplayMemberPath = "sehir";
            cmbSehir.SelectedValuePath = "id";
            cmbSehir.ItemsSource = dt.DefaultView;
            cmbSehir.Text = "Seçiniz";

        }
        void Rutbeler()
        {
            cNutusic.baglantiKontrol();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from PersonelRutbe", cNutusic.con);
            da.Fill(dt);
            cmbGorev.ItemsSource = dt.DefaultView;
            cmbGorev.DisplayMemberPath = "Rutbe";
            cmbGorev.SelectedValuePath = "RutbeID";
            
        }

        public void Listele()
        {
            cNutusic.baglantiKontrol();
            SqlDataAdapter da = new SqlDataAdapter("exec PersonelListe", cNutusic.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
            Sehirler();
            Rutbeler();
            Toplamisci();
            istenAyrilan();

        }

            private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            personel = this;
            Listele();
            Temizle();
            dataGrid1.AutoGenerateColumns = true;

        }

        private void cmbSehir_DropDownClosed(object sender, EventArgs e)
        {
            cNutusic.baglantiKontrol();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ilceler where sehir=" + cmbSehir.SelectedValue + "", cNutusic.con);
            da.Fill(dt);
            cmbIlce.ItemsSource = dt.DefaultView;
            cmbIlce.SelectedValuePath = "ilce";
            cmbIlce.DisplayMemberPath = "ilce";
            cmbIlce.Text = "Seçiniz";
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtPersonelID.Text = row_selected["PersonelID"].ToString();
                txtPersonelAd.Text = row_selected["PersonelAd"].ToString();
                txtPersonelSoyad.Text = row_selected["PersonelSoyad"].ToString();
                txtPersonelTelefon.Text = row_selected["Telefon"].ToString();
                txtTC.Text = row_selected["TC"].ToString();
                txtMail.Text = row_selected["Mail"].ToString();
                cmbSehir.Text = row_selected["Sehir"].ToString();
                cmbIlce.Text = row_selected["Ilce"].ToString();
                cmbGorev.Text = row_selected["Rutbe"].ToString();
                rchAdres.Document.Blocks.Clear();
                rchAdres.Document.Blocks.Add(new Paragraph(new Run(row_selected["Adres"].ToString())));
                txtKullaniciAdi.Text = row_selected["KullaniciAdi"].ToString();
                txtKullaniciSifre.Text = row_selected["Sifre"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        private void txtAra_TextChanged(object sender, TextChangedEventArgs e)
        {
            cNutusic.baglantiKontrol();
            SqlDataAdapter da = new SqlDataAdapter("select PersonelID,PersonelAd,PersonelSoyad,TC,Telefon,Mail,PersonelRutbe.Rutbe,Sehir,Ilce,Adres,KullaniciAdi,Sifre from Personeller  inner join PersonelRutbe on Personeller.Rutbe=PersonelRutbe.RutbeID where Personeller.Durum=1 and PersonelAd like '" + txtAra.Text + "%' order by RutbeID", cNutusic.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
        }

        private void btnGeriGel_Click(object sender, RoutedEventArgs e)
        {
            Menu me = new Menu();
            me.AktifKullanici = AktifKullanici;
            me.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand cmd = new SqlCommand("insert into Personeller (PersonelAd,PersonelSoyad,TC,Telefon,Mail,Rutbe,Sehir,Ilce,Adres,KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", cNutusic.con);
                cmd.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", txtTC.Text);
                cmd.Parameters.AddWithValue("@p4", txtPersonelTelefon.Text);
                cmd.Parameters.AddWithValue("@p5", txtMail.Text);
                cmd.Parameters.AddWithValue("@p6", cmbGorev.SelectedValue);
                cmd.Parameters.AddWithValue("@p7", cmbSehir.Text);
                cmd.Parameters.AddWithValue("@p8", cmbIlce.Text);
                string richText = new TextRange(rchAdres.Document.ContentStart, rchAdres.Document.ContentEnd).Text;

                cmd.Parameters.AddWithValue("@p9", richText);
                cmd.Parameters.AddWithValue("@p10", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@p11", txtKullaniciSifre.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Personel Ekleme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);

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
            }
        }

        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cNutusic.baglantiKontrol();
                SqlCommand cmd = new SqlCommand("update Personeller set PersonelAd=@p1,PersonelSoyad=@p2,Telefon=@p3,TC=@p4,Mail=@p5,Sehir=@p6,Ilce=@p7,Rutbe=@p8,Adres=@p9,KullaniciAdi=@p11,Sifre=@p12 where PersonelID=@p10", cNutusic.con);
                cmd.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", txtPersonelTelefon.Text);
                cmd.Parameters.AddWithValue("@p4", txtTC.Text);
                cmd.Parameters.AddWithValue("@p5", txtMail.Text);
                cmd.Parameters.AddWithValue("@p6", cmbSehir.Text);
                cmd.Parameters.AddWithValue("@p7", cmbIlce.Text);
                cmd.Parameters.AddWithValue("@p8", cmbGorev.SelectedValue);
                string richText = new TextRange(rchAdres.Document.ContentStart, rchAdres.Document.ContentEnd).Text;
                cmd.Parameters.AddWithValue("@p9", richText);
                cmd.Parameters.AddWithValue("@p10", txtPersonelID.Text);
                cmd.Parameters.AddWithValue("@p11", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@p12", txtKullaniciSifre.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel Güncelleme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                cNutusic.con.Close();
                Listele();
                Temizle();
            }
        }

        private void btnIstenCıkar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult secenek = MessageBox.Show("Yetkiliyi İşten Çıkarmak İstiyor Musunuz ?", "Bilgilendirme Penceresi", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (secenek == MessageBoxResult.Yes)
            {
                try
                {
                    cNutusic.baglantiKontrol();
                    SqlCommand cmd = new SqlCommand("update Personeller set Durum=0 where PersonelID=@p1", cNutusic.con);
                    cmd.Parameters.AddWithValue("@p1", txtPersonelID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kişi İşten Başarıyla Çıkarıldı.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show("Veri Tabanıyla Bağlantı Kurulurken Hata Oluştu. Hata Kodu 1", "Hata Penceresi", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                finally
                {
                    cNutusic.con.Close();
                    Listele();
                    Temizle();
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gorevler gr = new Gorevler();
            gr.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PersonelCikan pr = new PersonelCikan();
            pr.Show();
        }
    }
}
