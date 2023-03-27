using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜRÜN_TAKİP_SİSTEMİ
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private void btnKaydetF2_Click(object sender, EventArgs e)
        {
            ds.satis_ekle(int.Parse(txtBoxMusteri.Text), int.Parse(comboBox1.SelectedValue.ToString()), byte.Parse(txtBoxAdet.Text), 
                decimal.Parse(txtBoxFiyat.Text),decimal.Parse(txtBoxToplam.Text), DateTime.Parse(maskedTextBox1.Text));
            MessageBox.Show("Ürün Kaydedilmiştir.");
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbUrun;Integrated Security=True");
        DataSet1TableAdapters.TBL_SATISTableAdapter ds = new DataSet1TableAdapters.TBL_SATISTableAdapter();
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("execute satis_listesi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from tbl_urunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            comboBox1.ValueMember = "urunId";
            comboBox1.DisplayMember = "urun_ismi";
            comboBox1.DataSource = dt2;


            dataGridView1.DataSource = ds.satis_listesi();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int adet;
            double fiyat, toplam;
            adet=Convert.ToInt16(txtBoxAdet.Text);
            fiyat=Convert.ToDouble(txtBoxFiyat.Text);
            toplam = adet * fiyat;
            txtBoxToplam.Text = toplam.ToString();
        }
    }
}
