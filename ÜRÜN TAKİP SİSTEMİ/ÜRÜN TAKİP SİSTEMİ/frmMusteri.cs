using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜRÜN_TAKİP_SİSTEMİ
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBL_MUSTERITableAdapter tb = new DataSet1TableAdapters.TBL_MUSTERITableAdapter();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tb.musteri_listesi();    
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tb.eklemeIslemi(txtBoxMusteriAd.Text,txtBoxMusteriSoyad.Text,txtBoxSehir.Text,decimal.Parse(txtBoxBakiye.Text));
            MessageBox.Show("Müşteri kaydetme başarılı bir şekilde gerçekleştirildi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            tb.silmeIslemi(int.Parse(txtBoxMusteriID.Text));
            MessageBox.Show("silme işlemi tamamlandı."); 

        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxMusteriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBoxMusteriAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBoxMusteriSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBoxSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBoxBakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            tb.guncellemeIslemi(txtBoxMusteriAd.Text, txtBoxMusteriSoyad.Text, txtBoxSehir.Text, decimal.Parse(txtBoxBakiye.Text), int.Parse(txtBoxMusteriID.Text));
            MessageBox.Show("Verileriniz güncellendi.");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (radioBtnAd.Checked == true)
            {
                dataGridView1.DataSource = tb.adaGöre(txtBoxKelime.Text);
            }
            if (radioBtnSoyad.Checked == true)
            {
                dataGridView1.DataSource = tb.soyadaGöre(txtBoxKelime.Text);
            }
            if(radioBtnSehir.Checked == true)
            {
                dataGridView1.DataSource = tb.sehreGöre(txtBoxKelime.Text);
            }
        }
    }
}
