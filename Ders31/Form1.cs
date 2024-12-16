using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 4, 1, 3, 2, 5, 6, 7, 9 };
            Array.Sort(sayilar);
            for (int i = 0; i< sayilar.Length; i++)
            {
                if (sayilar[i]%2 == 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
