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
    public partial class frmurun : Form
    {
        public frmurun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void frmurun_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM,
                                        }).ToList();
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD,
                               }).ToList();
            CmbKategori.ValueMember = "ID";
            CmbKategori.DisplayMember = "AD";
            CmbKategori.DataSource = kategoriler;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM,
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = int.Parse(CmbKategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(TxtId.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(TxtId.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = TxtUrunAd.Text;
            urun.MARKA = TxtMarka.Text;
            urun.STOK = short.Parse(TxtStok.Text);
            urun.FIYAT = decimal.Parse(TxtFiyat.Text);
            urun.KATEGORI = int.Parse(CmbKategori.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtUrunAd.Text = "";
            TxtMarka.Text = "";
            TxtStok.Text = "";
            TxtFiyat.Text = "";
            TxtDurum.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
