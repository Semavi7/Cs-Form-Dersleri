using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tıklama = 0; // Basış sayısını takip eden sayaç
        int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tıklama++; // Basış sayısını artır

            if (tıklama % 2 == 1)
            {
                // İlk, üçüncü, beşinci ... basışlarda küp hesapla
                int s = Convert.ToInt32(textBox1.Text);
                label1.Text = kup(s).ToString();
            }
            else
            {
                // İkinci, dördüncü, altıncı ... basışlarda textBox'ı temizle ve focuslan
                textBox1.Clear();
                label1.Text = "0".ToString();
                textBox1.Focus();
            }

        }
    } 
}
