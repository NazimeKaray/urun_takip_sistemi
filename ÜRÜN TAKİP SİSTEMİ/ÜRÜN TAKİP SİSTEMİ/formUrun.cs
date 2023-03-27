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
    public partial class formUrun : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbUrun;Integrated Security=True");
        public formUrun()
        {
            InitializeComponent();
        }
        
        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formUrun_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from TBL_KATEGORİ", baglanti);
            SqlDataAdapter da2= new SqlDataAdapter(komut2);
            DataTable dt2= new DataTable();
            da2.Fill(dt2);
            comboBox1.DisplayMember = "kategori_ismi";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt2;
        }

        private void btnKaydetF2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3=new SqlCommand("insert into TBL_URUNLER (urun_ismi,stok,alis_fiyati,satis_fiyati,kategori) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut3.Parameters.AddWithValue("@p1", txtBoxUrnIsmi.Text);
            komut3.Parameters.AddWithValue("@p2",nudStok.Value);
            komut3.Parameters.AddWithValue("@p3",txtBoxAlis.Text);
            komut3.Parameters.AddWithValue("@p4", txtBoxSatis.Text);
            komut3.Parameters.AddWithValue("@p5",comboBox1.SelectedValue);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kaydetme işleminiz başarılı bir şekilde gerçekleşmiştir.");
        }

        private void txtBoxUrnIsmi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSilF2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBL_URUNLER where urunId=@p1 or urun_ismi=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", txtBoxUrunID.Text);
            komut.Parameters.AddWithValue("@p2", txtBoxUrnIsmi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ürün silme işlemi başarılı bir şekilde gerçekleştirildi.");

        }

        private void btnListeleF2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select urunId,urun_ismi,stok,alis_fiyati,satis_fiyati,kategori_ismi,kategori from TBL_URUNLER inner join TBL_KATEGORİ on TBL_URUNLER.kategori = TBL_KATEGORİ.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["kategori"].Visible=false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxUrunID.Text=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBoxUrnIsmi.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nudStok.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtBoxAlis.Text=dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBoxSatis.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.SelectedValue=dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnGuncelleF2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set urun_ismi=@p1,stok=@p2,alis_fiyati=@p3,satis_fiyati=@p4,kategori=@p5 where urunId=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBoxUrnIsmi.Text);
            komut.Parameters.AddWithValue("@p2",nudStok.Value);
            komut.Parameters.AddWithValue("@p3",decimal.Parse(txtBoxAlis.Text));
            komut.Parameters.AddWithValue("@p4",decimal.Parse(txtBoxSatis.Text));
            komut.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p6",txtBoxUrunID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ürün güncelleme işlemi başarılı bir şekilde gerçekleştirildi.","güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
