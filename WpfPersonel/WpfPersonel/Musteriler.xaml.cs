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
using System.Data;
using System.Data.SqlClient;

namespace WpfPersonel
{
    /// <summary>
    /// Interaction logic for Musteriler.xaml
    /// </summary>
    public partial class Musteriler : Window
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        YusufTahaEntities db = new YusufTahaEntities();

        public string AktifKullanici;
        public static Personeller personel;

        public void Temizle()
        {
            txtMusteriID.Text = "";
            txtMusteriAd.Text = "";
            txtMusteriSoyad.Text = "";
            txtTelefon.Text = "";
            txtMail.Text = "";
            cmbSehir.Text = "Seçiniz";
            cmbIlce.Text = "Seçiniz";
            rchAdres.Document.Blocks.Clear();
            
        }

        //void Sehirler()
        //{
        //    cNutusic.baglantiKontrol();
        //    SqlDataAdapter da = new SqlDataAdapter("select * from Sehirler", cNutusic.con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    cmbSehir.DisplayMemberPath = "sehir";
        //    cmbSehir.SelectedValuePath = "id";
        //    cmbSehir.ItemsSource = dt.DefaultView;
        //    cmbSehir.Text = "Seçiniz";   // ADO.NET
        //}

        void Sehirler()
        {
            var sehirler = (from x in db.Sehirler  // ENTITY
                            select new
                            {
                                x.id,
                                x.sehir,

                            }).ToList();
            cmbSehir.DisplayMemberPath = "sehir";
            cmbSehir.SelectedValuePath = "id";
            cmbSehir.ItemsSource = sehirler;
        }

        public void Listele()
        {
            cNutusic.baglantiKontrol();
            SqlDataAdapter da = new SqlDataAdapter("select MusteriID,MusteriAD,MusteriSoyad,Telefon,Mail,Sehir,Ilce,Adres from Musteriler where Durum=1 order by MusteriAd", cNutusic.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;

            Sehirler();  // ADO. NET

        }

        //void Listele()
        //{
        //    dataGrid1.ItemsSource = (from x in db.Musteriler  // ENTITY  //WPF'De entity ile listeleme yapıldığı taktirde DataGrid' de Row focus veya Cell Focus eventlerini kullanamadığım için Ado.net listelemesi kullanıldı.
        //                             select new
        //                             {
        //                                 x.MusteriID,
        //                                 x.MusteriAd,
        //                                 x.MusteriSoyad,
        //                                 x.Telefon,
        //                                 x.Mail,
        //                                 x.Sehir,
        //                                 x.Ilce,
        //                                 x.Adres
        //                             }).ToList();
        //    Sehirler();

        //}



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //    cNutusic.baglantiKontrol();
                //    SqlCommand cmd = new SqlCommand("insert into Musteriler (MusteriAd,MusteriSoyad,Telefon,Mail,Sehir,Ilce,Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", cNutusic.con);
                //    cmd.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
                //    cmd.Parameters.AddWithValue("@p2", txtMusteriSoyad.Text);
                //    cmd.Parameters.AddWithValue("@p3", txtTelefon.Text);
                //    cmd.Parameters.AddWithValue("@p4", txtMail.Text);
                //    cmd.Parameters.AddWithValue("@p5", cmbSehir.Text);
                //    cmd.Parameters.AddWithValue("@p6", cmbIlce.Text);
                //    string richText = new TextRange(rchAdres.Document.ContentStart, rchAdres.Document.ContentEnd).Text;
                //    cmd.Parameters.AddWithValue("@p7", richText);
                //    cmd.ExecuteNonQuery(); // ADO.NET

                Musteriler m = new Musteriler();   // ENTİTY Fr@mework
                m.MusteriAd = txtMusteriAd.Text;
                m.MusteriSoyad = txtMusteriSoyad.Text;
                m.Telefon = txtTelefon.Text;
                m.Mail = txtMail.Text;
                m.Sehir = cmbSehir.Text;
                m.Ilce = cmbIlce.Text;
                string richText = new TextRange(rchAdres.Document.ContentStart, rchAdres.Document.ContentEnd).Text;
                m.Adres = richText;
                m.Durum = true;
                db.Musteriler.Add(m);
                db.SaveChanges();


                MessageBox.Show("Müşteri Ekleme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void btnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //cNutusic.baglantiKontrol();
                //SqlCommand cmd = new SqlCommand("Update Musteriler set MusteriAd=@p1, MusteriSoyad=@p2, Telefon=@p3,Mail=@p4,Sehir=@p5,Ilce=@p6,Adres=@p7 where MusteriID=@p8", cNutusic.con);
                //cmd.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
                //cmd.Parameters.AddWithValue("@p2", txtMusteriSoyad.Text);
                //cmd.Parameters.AddWithValue("@p3", txtTelefon.Text);
                //cmd.Parameters.AddWithValue("@p4", txtMail.Text);
                //cmd.Parameters.AddWithValue("@p5", cmbSehir.Text);
                //cmd.Parameters.AddWithValue("@p6", cmbIlce.Text);
                //string richText = new TextRange(rchAdres.Document.ContentStart, rchAdres.Document.ContentEnd).Text;
                //cmd.Parameters.AddWithValue("@p7", richText);
                //cmd.Parameters.AddWithValue("@p8", txtMusteriID.Text);
                //cmd.ExecuteNonQuery();

                var musteri = db.Musteriler.Find(Convert.ToInt32(txtMusteriID.Text));  // ENTITY Fr@mework
                musteri.MusteriAd = txtMusteriAd.Text;
                musteri.MusteriSoyad = txtMusteriSoyad.Text;
                musteri.Telefon = txtTelefon.Text;
                musteri.Mail = txtMail.Text;
                musteri.Sehir = cmbSehir.Text;
                musteri.Ilce = cmbIlce.Text;
                string richText = new TextRange(rchAdres.Document.ContentStart, rchAdres.Document.ContentEnd).Text;
                musteri.Adres = richText;
                db.SaveChanges();
                Listele();


                MessageBox.Show("Müşteri Güncelleme İşlemi Başarıyla Gerçekleşti.", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
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
            try
            {
                //cNutusic.baglantiKontrol();
                //SqlCommand cmd = new SqlCommand("Update Musteriler set Durum=0 where MusteriID=@p1", cNutusic.con);
                //cmd.Parameters.AddWithValue("@p1", txtMusteriID.Text);
                //cmd.ExecuteNonQuery();
                                                             //ADONET//ADO.nET


                var musteri = db.Musteriler.Find(Convert.ToInt32(txtMusteriID.Text));  // ENTITY Fr@mework
                musteri.Durum = false;  
                db.SaveChanges();
                MessageBox.Show("Müşteri Bilgileri Kaldırıldı", "Bilgilendirme Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);

                Listele();

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
            }
        }

        private void btnTemizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        private void btnGeriGel_Click(object sender, RoutedEventArgs e)
        {
            Menu me = new Menu();
            me.AktifKullanici = AktifKullanici;
            me.Show();
            this.Hide();
        }

        private void cmbSehir_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbSehir.SelectedValue!=null)
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
            
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtMusteriID.Text = row_selected["MusteriID"].ToString();
                txtMusteriAd.Text = row_selected["MusteriAd"].ToString();
                txtMusteriSoyad.Text = row_selected["MusteriSoyad"].ToString();
                txtTelefon.Text = row_selected["Telefon"].ToString();
                txtMail.Text = row_selected["Mail"].ToString();
                cmbSehir.Text = row_selected["Sehir"].ToString();
                cmbIlce.Text = row_selected["Ilce"].ToString();
                rchAdres.Document.Blocks.Clear();
                rchAdres.Document.Blocks.Add(new Paragraph(new Run(row_selected["Adres"].ToString())));

            }
        }

       
    }
}
