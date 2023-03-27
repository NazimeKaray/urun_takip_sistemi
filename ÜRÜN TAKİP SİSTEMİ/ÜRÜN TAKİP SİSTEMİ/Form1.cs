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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBL_KATEGORİ where kategori_ismi=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBoxKategori.Text);   
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbUrun;Integrated Security=True");
        private void btnListele_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("select * from TBL_KATEGORİ", baglanti);
            SqlDataAdapter da=new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_KATEGORİ (kategori_ismi) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtBoxKategori.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kategori başarılı bir şekilde eklenmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("delete from TBL_KATEGORİ where ID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txtBoxID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme işleminiz başarılı bir şekilde gerçekleştirildi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_KATEGORİ set kategori_ismi=@p1 where ID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBoxKategori.Text);
            komut.Parameters.AddWithValue("p2", txtBoxID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("güncelleme işleminiz başarılı bir şekilde gerçekleştirildi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
//Data Source=localhost;Initial Catalog=dbUrun;Integrated Security=True
