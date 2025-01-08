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
    public partial class frmistatislik : Form
    {
        public frmistatislik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void frmistatislik_Load(object sender, EventArgs e)
        {
            TopKatSay.Text = db.TBLKATEGORI.Count().ToString();
            TopUruSay.Text = db.TBLURUN.Count().ToString();
            AktMusSay.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            PasMusSay.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            TopStok.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            KasTut.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString() + " TL";
            EnYükFiyUrun.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            EnDusFiyUrun.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            BeyEsySay.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            TopBuzSay.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            SehSay.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            EnFazUruMar.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
