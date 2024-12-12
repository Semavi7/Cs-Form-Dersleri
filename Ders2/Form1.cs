using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Mehmet Burçhan";
            label5.Text = "Gürses";
            label6.Text = "Yazılım Geliştirici";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = textBox1.Text;
        }
    }
}
