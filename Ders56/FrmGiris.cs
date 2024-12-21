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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6CFTTSA\\SQLEXPRESS;Initial Catalog=Personelveritabani;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici Where KullanıcıAd=@p1 and Sifre=@p2", baglantı);
            komut.Parameters.AddWithValue("@p1", KullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre");
            }
            baglantı.Close();
        }
    }
}
