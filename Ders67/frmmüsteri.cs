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
    public partial class frmmüsteri : Form
    {
        public frmmüsteri()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void frmmüsteri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLMUSTERI
                                        where x.DURUM == true
                                        select new 
                                        { 
                                            x.MUSTERIID, 
                                            x.MUSTERIAD,
                                            x.MUSTERISOYAD,
                                            x.SEHIR,
                                            DURUM = x.DURUM.HasValue && x.DURUM.Value ? "AKTİF" : "PASİF"
                                        }).ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            frmmüsteri_Load(sender, e);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLMUSTERI t = new TBLMUSTERI();
            t.MUSTERIAD = TxtAd.Text;
            t.MUSTERISOYAD = TxtSoyad.Text;
            t.SEHIR = TxtSehir.Text;
            if (radioButton1.Checked == true)
            {
                t.DURUM = true;
            }
            if (radioButton2.Checked == true)
            {
                t.DURUM = false;
            }
            db.TBLMUSTERI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPasifler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLMUSTERI
                                        where x.DURUM == false
                                        select new
                                        {
                                            x.MUSTERIID,
                                            x.MUSTERIAD,
                                            x.MUSTERISOYAD,
                                            x.SEHIR,
                                            DURUM = x.DURUM.HasValue && x.DURUM.Value ? "AKTİF" : "PASİF"
                                        }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "AKTİF" )
            {
                radioButton1.Checked = true;
            }
            if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "PASİF")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(TxtId.Text);
            var mus = db.TBLMUSTERI.Find(x);
            mus.MUSTERIAD = TxtAd.Text;
            mus.MUSTERISOYAD = TxtSoyad.Text;
            mus.SEHIR = TxtSehir.Text;
            if (radioButton1.Checked == true)
            {
                mus.DURUM = true;
            }
            if (radioButton2.Checked == true)
            {
                mus.DURUM = false;
            }
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(TxtId.Text);
            var mus = db.TBLMUSTERI.Find(x);
            db.TBLMUSTERI.Remove(mus);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSehir.Text = "";
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
            }
            if(radioButton2.Checked == true)
            {
                radioButton2.Checked = false;
            }
        }
    }
}
