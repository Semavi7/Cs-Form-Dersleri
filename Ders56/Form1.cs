using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ders56
{
    public partial class FrmAnaForm : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6CFTTSA\\SQLEXPRESS;Initial Catalog=Personelveritabani;Integrated Security=True");

        void temizle()
        {
            Txtid.Text = "";
            Txtad.Text = "";
            Txtsoyad.Text = "";
            Txtmeslek.Text = "";
            Mskmaas.Text = "";
            Cmbsehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            Txtad.Focus();
        }
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelveritabaniDataSet2.iller' table. You can move, or remove it, as needed.
            this.illerTableAdapter.Fill(this.personelveritabaniDataSet2.iller);
            this.tbl_PersonelTableAdapter.Fill(this.personelveritabaniDataSet.Tbl_Personel);
        }

        private void Btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelveritabaniDataSet.Tbl_Personel);
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (perad,persoyad,persehir,permaas,permeslek,perdurum) values (@1,@2,@3,@4,@5,@6)", baglantı);
            komut.Parameters.AddWithValue("@1", Txtad.Text);
            komut.Parameters.AddWithValue("@2", Txtsoyad.Text);
            komut.Parameters.AddWithValue("@3", Cmbsehir.Text);
            komut.Parameters.AddWithValue("@4", Mskmaas.Text);
            komut.Parameters.AddWithValue("@5", Txtmeslek.Text);
            komut.Parameters.AddWithValue("@6", label8.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Cmbsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Mskmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel where Perid=@k1", baglantı);
            komutsil.Parameters.AddWithValue("@k1",Txtid.Text);
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set Perad=@a1,Persoyad=@a2,Persehir=@a3,Permaas=@a4,Perdurum=@a5,Permeslek=@a6 where Perid=@a7", baglantı);
            komutguncelle.Parameters.AddWithValue("@a1", Txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", Txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", Cmbsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", Mskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", Txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txtid.Text);
            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Bilgi Güncellendi");
        }

        private void Btnistatislik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.Show();
        }

        private void Btngrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frp = new Form2();
            frp.Show();
        }
    }
}
