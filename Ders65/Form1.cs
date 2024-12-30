using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders65
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt16(textBox1.Text);
                int sayi2 = Convert.ToInt16(textBox2.Text);
                int toplam = sayi1 * sayi2;
                label3.Text = toplam.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                MessageBox.Show("Finally Kodu Çalıştı");
            }
        }
    }
}
