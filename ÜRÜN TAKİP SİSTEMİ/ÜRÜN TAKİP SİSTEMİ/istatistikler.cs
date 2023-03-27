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
    public partial class istatistikler : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbUrun;Integrated Security=True");
        public istatistikler()
        {
            InitializeComponent();
        }

        private void istatistikler_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(*) from TBL_KATEGORİ", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblToplamKategori.Text = reader[0].ToString();
            }
            baglanti.Close();



            //Toplam Ürün Sayısı

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from TBL_URUNLER", baglanti);
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read())
            {
                lblToplamUrun.Text = reader1[0].ToString();
            }
            baglanti.Close();



            //En Düşük Stoklu Ürün

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBL_URUNLER where stok=(select min(stok)from TBL_URUNLER)", baglanti);
            SqlDataReader reader2 = komut2.ExecuteReader();
            while (reader2.Read())
            {
                lblMin.Text = reader2["urun_ismi"].ToString();
            }
            baglanti.Close();



            //En Yüksek Stoklu Ürün

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBL_URUNLER where stok=(select max(stok)from TBL_URUNLER)", baglanti);
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                lblMax.Text = reader3["urun_ismi"].ToString();
            }
            baglanti.Close();


            //Beyaz Eşya Sayısı

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(*) from TBL_URUNLER WHERE kategori=(select ID from TBL_KATEGORİ where kategori_ismi='beyaz eşya')", baglanti);
            SqlDataReader reader4 = komut4.ExecuteReader();
            while (reader4.Read())
            {
                lblBeyazEsya.Text = reader4[0].ToString();
            }
            baglanti.Close();


            //Küçük Ev Aletleri Sayısı

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select count(*) from TBL_URUNLER WHERE kategori=(select ID from TBL_KATEGORİ where kategori_ismi='küçük ev aletleri')", baglanti);
            SqlDataReader reader5 = komut5.ExecuteReader();
            while (reader5.Read())
            {
                lblKucukEvAleti.Text = reader5[0].ToString();
            }
            baglanti.Close();


            //Laptopların Toplam Karı

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select stok*((satis_fiyati)-(alis_fiyati)) from TBL_URUNLER where urun_ismi='laptop'", baglanti);
            SqlDataReader reader6 = komut6.ExecuteReader();
            while (reader6.Read())
            {
                lblLaptopKari.Text = reader6[0].ToString() +" ₺";
            }
            baglanti.Close();


            //Beyaz Eşyaların Toplam Karı

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(stok * (satis_fiyati - alis_fiyati)) from tbl_urunler where kategori = (select ID from TBL_KATEGORİ where kategori_ismi = 'beyaz eşya')", baglanti);
            SqlDataReader reader7 = komut7.ExecuteReader();
            while (reader7.Read())
            {
                lblBeyazEsyaKar.Text = reader7[0].ToString() + " ₺";
            }
            baglanti.Close();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }

        private void lblMax_Click(object sender, EventArgs e)
        {

        }
    }
}
