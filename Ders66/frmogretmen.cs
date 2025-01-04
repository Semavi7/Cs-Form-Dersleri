using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders66
{
    public partial class frmogretmen : Form
    {
        public frmogretmen()
        {
            InitializeComponent();
        }

        private void BtnKulup_Click(object sender, EventArgs e)
        {
            frmkulup fr = new frmkulup();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmdersler fr = new frmdersler();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmogrenci fr = new frmogrenci();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmsınavnotlar fr = new frmsınavnotlar();
            fr.Show();
        }
    }
}
