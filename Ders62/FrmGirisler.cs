using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Derrs61;

namespace Ders62
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm = new FrmDoktorGiris();
            frm.Show();
            this.Hide();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş fr = new FrmSekreterGiriş();
            fr.Show();
            this.Hide();
        }
    }
}
