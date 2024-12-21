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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6CFTTSA\\SQLEXPRESS;Initial Catalog=Personelveritabani;Integrated Security=True");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel",baglantı);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=1", baglantı);
            SqlDataReader d2 = komut2.ExecuteReader();
            while (d2.Read())
            {
                LblEvliPersonel.Text = d2[0].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=0", baglantı);
            SqlDataReader d3 = komut3.ExecuteReader();
            while (d3.Read())
            {
                LblBekarPersonel.Text = d3[0].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komu4 = new SqlCommand("Select Count(distinct(Persehir)) From Tbl_Personel", baglantı);
            SqlDataReader d4 = komu4.ExecuteReader();
            while (d4.Read())
            {
                LblSehirSayısı.Text = d4[0].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(Permaas) From Tbl_Personel",baglantı);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblToplamMaas.Text = dr5[0].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(Permaas) From Tbl_Personel", baglantı);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglantı.Close();
        }
    }
}
