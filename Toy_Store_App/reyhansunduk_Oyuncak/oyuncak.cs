using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reyhansunduk_Oyuncak
{
   public class oyuncak
    {
       
        private string _Ad;
        private string _Soyad;
        private string _Telno;

        public int Id { get; set; }
        public string oyuncakci  { get;set;}
        public string Ad 
        {
            get { return _Ad; }
            set
            {
                try
                {
                    _Ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                }
                catch (System.ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Adınızı giriniz!","Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }
        public string Soyad
        {
            get { return _Soyad; }
            set 
            {
               
                try
                {
                    _Soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                }
                catch (System.ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Soyadınızı giriniz!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public string Telno { get; set; }
        public int Adet { get; set; }
        public string YasKategori { get; set; }
        public string Barkod 
        {
            get; 
            set; 
        }
        public string Fiyat
        {
            get;
            set;
        }




    }
}
