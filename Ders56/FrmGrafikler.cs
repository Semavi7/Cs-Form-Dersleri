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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6CFTTSA\\SQLEXPRESS;Initial Catalog=Personelveritabani;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutg1 = new SqlCommand("Select Persehir, Count(*) From Tbl_Personel Group By Persehir", baglantı);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komutg2 = new SqlCommand("Select Permeslek, Avg(Permaas) From Tbl_Personel Group by Permeslek", baglantı);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglantı.Close();
        }
    }
}
