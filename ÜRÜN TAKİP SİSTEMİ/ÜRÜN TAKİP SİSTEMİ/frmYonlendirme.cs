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
    public partial class frmYonlendirme : Form
    {
        public frmYonlendirme()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmYonlendirme_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel_kategoriİslm(object sender, EventArgs e)
        {
            Form1 kategori_formu=new Form1();
            kategori_formu.Show();
        }   

        private void panel_urunİslm(object sender, EventArgs e)
        {
            formUrun formUrun = new formUrun();
            formUrun.Show();
        }

        private void pnlIstatistik_Click(object sender, EventArgs e)
        {
            istatistikler frmIstatistik=new istatistikler();
            frmIstatistik.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            adminPaneli frmAdmin=new adminPaneli();
            frmAdmin.Show();
            this.Hide();
        }
    }
}
