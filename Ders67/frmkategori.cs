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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLKATEGORI
                                        select new
                                        {
                                            x.ID,
                                            x.AD,
                                        }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLKATEGORI
                                        select new
                                        {
                                            x.ID,
                                            x.AD,
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TxtAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(TxtId.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(TxtId.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
