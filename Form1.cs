using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Queue otopark = new Queue();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        int ort = 0;
        private void ekleBTN_Click(object sender, EventArgs e)
        {
            Arac a = new Arac();
            Random r = new Random();
            a.AracNo = Convert.ToInt32(aracnoTXT.Text);
            a.IslemSuresi = r.Next(1, 300);
            otopark.Enqueue(a);
            int sure = 0;
            foreach (Arac item in otopark)
            {
                sure += item.IslemSuresi;
                
            }
            a.BeklemeSuresi = sure;
            
            ort += a.IslemSuresi;
            aracnoTXT.Clear();
        }

        private void listeBTN_Click(object sender, EventArgs e)
        {

        }

        private void listeeBTN_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            foreach (Arac item in otopark)
            {
                
                listBox1.Items.Add("Arac No: "+item.AracNo+"  İşlem Süresi : "+item.IslemSuresi+"  Bekleme Süresi: "+item.BeklemeSuresi+" Saniye");
            }
        }

        private void cikarBTN_Click(object sender, EventArgs e)
        {
            if (otopark.Count != 0)
                otopark.Dequeue();
            else
                MessageBox.Show("Otopark Boş");
        }

        private void ortBTN_Click(object sender, EventArgs e)
        {
            int c = otopark.Count;
            if(otopark.Count != 0)
            MessageBox.Show("Ortalama İşlem Süresi :  " + ort/c);
            else
                MessageBox.Show("Otopark Boş");
        }
    }
}
