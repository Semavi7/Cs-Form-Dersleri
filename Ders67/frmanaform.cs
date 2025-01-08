using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders67
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            Kategori fr = new Kategori();
            fr.Show();
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            frmurun fr = new frmurun();
            fr.Show();
        }

        private void BtnIst_Click(object sender, EventArgs e)
        {
            frmistatislik fr = new frmistatislik();
            fr.Show();
        }

        private void frmanaform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
