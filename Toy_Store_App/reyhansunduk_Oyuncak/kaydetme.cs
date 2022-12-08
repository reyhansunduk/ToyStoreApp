using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reyhansunduk_Oyuncak
{
    public partial class kaydetme : Form
    {
        public kaydetme(List<oyuncak> iliste )
        {
            InitializeComponent();
            oyuncaklist = iliste;
            dataGridView1.DataSource = (oyuncaklist);
            if (oyuncaklist.Count() > 0)
            {
                sayac = oyuncaklist[oyuncaklist.Count() - 1].Id + 1;
            }
            else
                sayac = 1;

        }
        List<oyuncak> oyuncaklist = new List<oyuncak>();
        double[] fiyatdizisi = new double[20];
        double toplamTutar = 0;

        int sayac = 1;
        private void kaydetme_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1(oyuncaklist);
            geri.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kaydetme hesapla = new kaydetme(oyuncaklist);
            foreach (double item in fiyatdizisi)
            {
                toplamTutar += item;
            }

            MessageBox.Show($"Toplam = {toplamTutar}");

            toplamTutar = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < fiyatdizisi.Length; i++)
            {
                fiyatdizisi[i] = 0;
            }
          
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                kaydetme hesapla = new kaydetme(oyuncaklist);
                for (int i = 0; i < hesapla.dataGridView1.RowCount; i++)
                {
                    if (hesapla.dataGridView1.Rows[i].Cells[7].Value.ToString() == textBox1.Text)
                    {
                        listBox1.Items.Add("Ad:" + hesapla.dataGridView1.Rows[i].Cells["Ad"].Value.ToString());
                        listBox1.Items.Add("Soyad:" + hesapla.dataGridView1.Rows[i].Cells["Soyad"].Value.ToString());
                        listBox1.Items.Add("Tel No:" + hesapla.dataGridView1.Rows[i].Cells["Telno"].Value.ToString());
                        listBox1.Items.Add("Adet:" + hesapla.dataGridView1.Rows[i].Cells["Adet"].Value.ToString());
                        listBox1.Items.Add("Yaş Kategori:" + hesapla.dataGridView1.Rows[i].Cells["YasKategori"].Value.ToString());
                        listBox1.Items.Add("Barkod:" + hesapla.dataGridView1.Rows[i].Cells["Barkod"].Value.ToString());
                        listBox1.Items.Add("\n -----------------");

                    }
                }
                for (int i = 0; i < fiyatdizisi.Length; i++)
                {
                    if (hesapla.dataGridView1.Rows[i].Cells[7].Value.ToString() == textBox1.Text)
                    {
                        if (fiyatdizisi[i] == 0)
                        {
                            fiyatdizisi[i] = Convert.ToDouble(hesapla.dataGridView1.Rows[i].Cells["Fiyat"].Value.ToString());
                            break;
                        }
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

                MessageBox.Show("Barkod değeri olmayan bir numara girdiniz! " +
              "Lütfen geçerli barkod numarası giriniz!","uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           

           
        }
        oyuncak  silme= new oyuncak();
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < oyuncaklist.Count(); i++)
            {
                if (oyuncaklist[i].Id==silme.Id)
                {
                    oyuncaklist.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = oyuncaklist;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            silme.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
 