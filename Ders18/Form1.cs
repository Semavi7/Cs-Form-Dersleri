using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "yaz": label2.Text = "haziran temmuz ağustos"; break;
                case "sonbahar": label2.Text = "eylül ekim kasım"; break;
                case "kış":label2.Text = "aralık ocak şubat"; break;
                case "ilkbahar":label2.Text = "mart nisan mayıs"; break;
                default:label2.Text = "hatalı mevsim"; break;
            }
        }
    }
}
