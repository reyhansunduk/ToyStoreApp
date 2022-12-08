using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace reyhansunduk_Oyuncak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public Form1(List<oyuncak> iliste)
        {
            InitializeComponent();
            oyuncaklist = iliste;
            if (oyuncaklist.Count() > 0)
            {
                sayac = oyuncaklist[oyuncaklist.Count() - 1].Id + 1;
            }
            else
                sayac = 1;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
          


        }
        List<oyuncak> oyuncaklist = new List<oyuncak>();
        oyuncak radioOyuncak = new oyuncak();
        string[] oyuncak_listele;
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            txtTelNo.MaxLength = 11;
            txtBarkod.MaxLength = 4;

        }
        
        int sayac = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            oyuncak oyn = new oyuncak();
            oyn.Id = sayac;
            oyn.Ad = txtAd.Text;
            oyn.Soyad = txtSoyad.Text;
            oyn.Telno = txtTelNo.Text;
            oyn.Barkod = txtBarkod.Text;
            oyn.oyuncakci = comboBox1.Text;
            oyn.Adet = Convert.ToInt32(numericUpDown1.Value);
            oyn.Fiyat = txtFiyat.Text;
            sayac++;
            oyuncaklist.Add(oyn);
            yasKategori();
            oyn.YasKategori = radioOyuncak.YasKategori;
            txtAd.Clear();
            txtSoyad.Clear();
            txtBarkod.Clear();
            txtFiyat.Clear();
            txtTelNo.Clear();
            comboBox1.Text = "";
          

        }
        private void yasKategori()
        {
            if (sifironikiay.Checked == true)
            {
                radioOyuncak.YasKategori = sifironikiay.Text;
            }
            else if (onikiyirmidortay.Checked == true)
            {
                radioOyuncak.YasKategori = onikiyirmidortay.Text;
            }
            else if (ucdortyas.Checked == true)
            {
                radioOyuncak.YasKategori = ucdortyas.Text;
            }
            else if (besaltiyas.Checked == true)
            {
                radioOyuncak.YasKategori = besaltiyas.Text;
            }
            else if (yedisekizyas.Checked == true)
            {
                radioOyuncak.YasKategori = yedisekizyas.Text;
            }
            else if (dokuzonyas.Checked == true)
            {
                radioOyuncak.YasKategori = dokuzonyas.Text;
            }
            else if (onbironikiyas.Checked == true)
            {
                radioOyuncak.YasKategori = onbironikiyas.Text;
            }
            else if (tumyaslar.Checked == true)
            {
                radioOyuncak.YasKategori = tumyaslar.Text;
            }
        }
        private void temizle()
        {
            comboBox1.Items.Clear();
        }
        private void sifironikiay_Click(object sender, EventArgs e)
        {
            temizle();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Clementoni Baby Clementoni Renkli Anahtarlar ");
            comboBox1.Items.Add("Sevimli Arkadaşım Panda");
            comboBox1.Items.Add("Resimli İlk Kitabım Maymun");
            comboBox1.Items.Add("Kanz İlk Arkadaşım Halka Çıngıraklar");
            comboBox1.Items.Add("Minik Hayvancıklar Arı Dişlik");
            comboBox1.Items.Add("Sevimli Baykuş");
            comboBox1.Items.Add("Sarılan Köpekçik");
            comboBox1.Items.Add("Oturan Koca Ayı ");
            comboBox1.Items.Add("Banyocu Ördek Sarı");
            comboBox1.Items.Add("İlk Arkadaşım Boncuklar");
            comboBox1.Items.Add("Sevimli Kuş");
          


        }
        private void onikiyirmidortay_Click(object sender, EventArgs e)
        {
            temizle();
            comboBox1.Items.Add("Bas Gitsin Oyuncak Araba");
            comboBox1.Items.Add("Atlı Karınca");
            comboBox1.Items.Add("Eğitici Köpekçik");
            comboBox1.Items.Add("Sallanan Araba Oyun Seti");
            comboBox1.Items.Add("Yaşa Göre Gelişim Eğitici Tablet");
            comboBox1.Items.Add("Renkli Araçlar");
            comboBox1.Items.Add("Baby Akıllı Telefon");
            comboBox1.Items.Add("Hayvanat Bahçesi Arkadaşları Zürafa Çıngırak");
            comboBox1.Items.Add("Resimli İlk Kitabım Maymun");
            comboBox1.Items.Add("Eğlenceli Fil");
            comboBox1.Items.Add("Prenses Kalesi Oyun Seti");
        }
        private void ucdortyas_Click(object sender, EventArgs e)
        {
            temizle();
            comboBox1.Items.Add("Yaşa Göre Gelişim Köpekçik Doktorda");
            comboBox1.Items.Add("Metal Araç Mini Figür");
            comboBox1.Items.Add("Metal İtfaiye İstasyonu Oyun Seti");
            comboBox1.Items.Add("Macera Merkez İstasyon Oyun Seti");
            comboBox1.Items.Add("Fırlatıcılı ve Dönemeçli Yol Seti");
            comboBox1.Items.Add("Oyuncak Motorsiklet 8 cm Cykons");
            comboBox1.Items.Add("Kargo Uçağı Sesli Işıklı"); 
            comboBox1.Items.Add("Barbie Sonsuz Hareket Bebekleri ");
            comboBox1.Items.Add("Hello Kitty İt Gitsin Eğlenceli Oyuncak Figür");
            comboBox1.Items.Add("Dump Truck İş Makinası");
            comboBox1.Items.Add("Avengers Süpriz Yumurta Figür");
           
        }
        private void besaltiyas_Click(object sender, EventArgs e)
        {
            temizle();
            comboBox1.Items.Add("Heykelciğini Yarat Avengers 6'lı Paket");
            comboBox1.Items.Add("Heykelciğini Yarat Cars 3 Guido Araç");
            comboBox1.Items.Add("Heykelciğini Yarat Frozen 4'lü Set");
            comboBox1.Items.Add("Metal Polis Merkezi Oyun Seti");
            comboBox1.Items.Add("Çoklu Fırlatıcılı Yol Seti");
            comboBox1.Items.Add("Eğtici Köpekçik");
            comboBox1.Items.Add("20 Parça Konuşan Yumuşak Puzzle Prenses");
            comboBox1.Items.Add("Silverlit İlk İtfaiye Helikopterim");
            comboBox1.Items.Add("Hot Wheels City Kobra Macerası Oyun Seti");
            comboBox1.Items.Add("20 Parça Araba Seti");
            comboBox1.Items.Add("Tekli Sürpriz Paket 2.Seri");
            

        }
        private void yedisekizyas_Click(object sender, EventArgs e)
        {
            temizle();
            comboBox1.Items.Add("Monopoly");
            comboBox1.Items.Add("Çizen Burun Kutu Oyunu");
            comboBox1.Items.Add("Green Board Hikaye Kartları");
            comboBox1.Items.Add("Set Aile Oyunu");
            comboBox1.Items.Add("Tik Tak Bomm Ekstra ");
            comboBox1.Items.Add("Uno Kartlar ");
            comboBox1.Items.Add("LEGO Marvel Shuri'nin Laboratuvarı");
            comboBox1.Items.Add("Kereste Kamyonu ");
            comboBox1.Items.Add("Taşınır Tren Garajı");
            comboBox1.Items.Add("Cayro Kutu Oyunu Sky Line");
            comboBox1.Items.Add("UNO Extreme Kartlar");
           
        }
        private void dokuzonyas_Click(object sender, EventArgs e)
        {
            temizle();
            comboBox1.Items.Add("Scrabble Travel Türkçe");
            comboBox1.Items.Add("Bilim ve Oyun Mekanik Laboratuvarı Uçak");
            comboBox1.Items.Add("3D 150 Parça Puzzle Eyüp Sultan Camii");
            comboBox1.Items.Add("3D 66 Parça Led Puzzle Kız Kulesi");
            comboBox1.Items.Add("Heykelciğini Yarat Frozen 4'lü Set");
            comboBox1.Items.Add("Monopoly Yeni Piyon Serisi Kutu Oyunu");
            comboBox1.Items.Add("Oyuncak Motorsiklet 8 cm Cykons");
            comboBox1.Items.Add("Dönüşebilen Numaralar Tank");
            comboBox1.Items.Add("Kedi Figürlü Bant Makinesi");
            comboBox1.Items.Add("Sesli ve Işıklı Araba Sarı");
            comboBox1.Items.Add("Uzaktan Kumandalı Ninja Turtles Party");
           
        }
        private void onbironikiyas_Click(object sender, EventArgs e)
        {
            temizle();
            comboBox1.Items.Add("Oyuncak Araba Mor");
            comboBox1.Items.Add("Dönüşebilen Numaralar Savaş Topu");
            comboBox1.Items.Add("Mini Peri Saksısı Turuncu");
            comboBox1.Items.Add("Sulama Kabı ve Peri Evi");
            comboBox1.Items.Add("Peri Çiçek Saksısı");
            comboBox1.Items.Add("Peri Bahçesi");
            comboBox1.Items.Add("Lavabo Figürlü Ataçlık");
            comboBox1.Items.Add("Tigger 3d Figür Klipli Çerceve");
            comboBox1.Items.Add("Rumbler Oyuncak Araba Yeşil");
            comboBox1.Items.Add("Peluş Ayı");
            comboBox1.Items.Add("Oyun Hamuru");
           
        }
        private void tumyaslar_Click(object sender, EventArgs e)
        {
            temizle();

            comboBox1.Items.Add("Clementoni Baby Clementoni Renkli Anahtarlar");
            comboBox1.Items.Add("Sevimli Arkadaşım Panda");
            comboBox1.Items.Add("Resimli İlk Kitabım Maymun");
            comboBox1.Items.Add("Kanz İlk Arkadaşım Halka Çıngıraklar");
            comboBox1.Items.Add("Minik Hayvancıklar Arı Dişlik");
            comboBox1.Items.Add("Sevimli Baykuş");
            comboBox1.Items.Add("Sarılan Köpekçik");
            comboBox1.Items.Add("Oturan Koca Ayı ");
            comboBox1.Items.Add("Banyocu Ördek Sarı");
            comboBox1.Items.Add("İlk Arkadaşım Boncuklar");
            comboBox1.Items.Add("Sevimli Kuş");

            /////
            ///
            comboBox1.Items.Add("Bas Gitsin Oyuncak Araba");
            comboBox1.Items.Add("Atlı Karınca");
            comboBox1.Items.Add("Eğitici Köpekçik");
            comboBox1.Items.Add("Sallanan Araba Oyun Seti");
            comboBox1.Items.Add("Yaşa Göre Gelişim Eğitici Tablet");
            comboBox1.Items.Add("Renkli Araçlar");
            comboBox1.Items.Add("Baby Akıllı Telefon");
            comboBox1.Items.Add("Hayvanat Bahçesi Arkadaşları Zürafa Çıngırak");
            comboBox1.Items.Add("Resimli İlk Kitabım Maymun");
            comboBox1.Items.Add("Eğlenceli Fil");
            comboBox1.Items.Add("Prenses Kalesi Oyun Seti");
          

            //
            comboBox1.Items.Add("Yaşa Göre Gelişim Köpekçik Doktorda");
            comboBox1.Items.Add("Metal Araç Mini Figür");
            comboBox1.Items.Add("Metal İtfaiye İstasyonu Oyun Seti");
            comboBox1.Items.Add("Macera Merkez İstasyon Oyun Seti");
            comboBox1.Items.Add("Fırlatıcılı ve Dönemeçli Yol Seti");
            comboBox1.Items.Add("Oyuncak Motorsiklet 8 cm Cykons");
            comboBox1.Items.Add("Kargo Uçağı Sesli Işıklı");
            comboBox1.Items.Add("Barbie Sonsuz Hareket Bebekleri ");
            comboBox1.Items.Add("Hello Kitty İt Gitsin Eğlenceli Oyuncak Figür");
            comboBox1.Items.Add("Dump Truck İş Makinası");
            comboBox1.Items.Add("Avengers Süpriz Yumurta Figür");
           
            //
            comboBox1.Items.Add("Heykelciğini Yarat Avengers 6'lı Paket");
            comboBox1.Items.Add("Heykelciğini Yarat Cars 3 Guido Araç");
            comboBox1.Items.Add("Heykelciğini Yarat Frozen 4'lü Set");
            comboBox1.Items.Add("Metal Polis Merkezi Oyun Seti");
            comboBox1.Items.Add("Çoklu Fırlatıcılı Yol Seti");
            comboBox1.Items.Add("Eğtici Köpekçik");
            comboBox1.Items.Add("20 Parça Konuşan Yumuşak Puzzle Prenses");
            comboBox1.Items.Add("Silverlit İlk İtfaiye Helikopterim");
            comboBox1.Items.Add("Hot Wheels City Kobra Macerası Oyun Seti");
            comboBox1.Items.Add("20 Parça Araba Seti");
            comboBox1.Items.Add("Tekli Sürpriz Paket 2.Seri");
       
            //
            comboBox1.Items.Add("Monopoly");
            comboBox1.Items.Add("Çizen Burun Kutu Oyunu");
            comboBox1.Items.Add("Green Board Hikaye Kartları");
            comboBox1.Items.Add("Set Aile Oyunu");
            comboBox1.Items.Add("Tik Tak Bomm Ekstra ");
            comboBox1.Items.Add("Uno Kartlar ");
            comboBox1.Items.Add("LEGO Marvel Shuri'nin Laboratuvarı");
            comboBox1.Items.Add("Kereste Kamyonu ");
            comboBox1.Items.Add("Taşınır Tren Garajı");
            comboBox1.Items.Add("Cayro Kutu Oyunu Sky Line");
            comboBox1.Items.Add("UNO Extreme Kartlar");
         
            //
            comboBox1.Items.Add("Scrabble Travel Türkçe");
            comboBox1.Items.Add("Bilim ve Oyun Mekanik Laboratuvarı Uçak");
            comboBox1.Items.Add("3D 150 Parça Puzzle Eyüp Sultan Camii");
            comboBox1.Items.Add("3D 66 Parça Led Puzzle Kız Kulesi");
            comboBox1.Items.Add("Heykelciğini Yarat Frozen 4'lü Set");
            comboBox1.Items.Add("Monopoly Yeni Piyon Serisi Kutu Oyunu");
            comboBox1.Items.Add("Oyuncak Motorsiklet 8 cm Cykons");
            comboBox1.Items.Add("Dönüşebilen Numaralar Tank");
            comboBox1.Items.Add("Kedi Figürlü Bant Makinesi");
            comboBox1.Items.Add("Sesli ve Işıklı Araba Sarı");
            comboBox1.Items.Add("Uzaktan Kumandalı Ninja Turtles Party");
         

            //
            comboBox1.Items.Add("Oyuncak Araba Mor");
            comboBox1.Items.Add("Dönüşebilen Numaralar Savaş Topu");
            comboBox1.Items.Add("Mini Peri Saksısı Turuncu");
            comboBox1.Items.Add("Sulama Kabı ve Peri Evi");
            comboBox1.Items.Add("Peri Çiçek Saksısı");
            comboBox1.Items.Add("Peri Bahçesi");
            comboBox1.Items.Add("Lavabo Figürlü Ataçlık");
            comboBox1.Items.Add("Tigger 3d Figür Klipli Çerceve");
            comboBox1.Items.Add("Rumbler Oyuncak Araba Yeşil");
            comboBox1.Items.Add("Peluş Ayı");
            comboBox1.Items.Add("Oyun Hamuru");
       
            //

        }
        private void btnDepo_Click(object sender, EventArgs e)
        {


            kaydetme kaydetme = new kaydetme(oyuncaklist);
            kaydetme.Show();
            this.Hide();
          
        }

        private void txtTelNo_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void txtTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
          
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)  && !char.IsControl(e.KeyChar) && e.KeyChar != '.'; ;
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
