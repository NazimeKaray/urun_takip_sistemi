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

namespace ÜRÜN_TAKİP_SİSTEMİ
{
    public partial class adminPaneli : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbUrun;Integrated Security=True");
        public adminPaneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Admin where kullanici_adi=@p1 and sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1",txtBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBoxSifre.Text);
            SqlDataReader reader=komut.ExecuteReader();
            if (reader.Read())
            {
                frmYonlendirme fr = new frmYonlendirme();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
