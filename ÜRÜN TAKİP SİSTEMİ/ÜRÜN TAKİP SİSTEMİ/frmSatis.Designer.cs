namespace ÜRÜN_TAKİP_SİSTEMİ
{
    partial class frmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListele = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblUrun = new System.Windows.Forms.Label();
            this.txtBoxAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtBoxFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtBoxMusteri = new System.Windows.Forms.TextBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.txtBoxMusteriID = new System.Windows.Forms.TextBox();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxToplam = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(91, 206);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(150, 30);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblToplam.Location = new System.Drawing.Point(26, 141);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(59, 15);
            this.lblToplam.TabIndex = 17;
            this.lblToplam.Text = "Toplam:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(91, 242);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 30);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydetF2_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(91, 314);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 30);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(91, 278);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(150, 30);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrun.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblUrun.Location = new System.Drawing.Point(43, 63);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(42, 15);
            this.lblUrun.TabIndex = 11;
            this.lblUrun.Text = "Ürün:";
            // 
            // txtBoxAdet
            // 
            this.txtBoxAdet.Location = new System.Drawing.Point(91, 88);
            this.txtBoxAdet.Name = "txtBoxAdet";
            this.txtBoxAdet.Size = new System.Drawing.Size(150, 20);
            this.txtBoxAdet.TabIndex = 10;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblAdet.Location = new System.Drawing.Point(46, 89);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(39, 15);
            this.lblAdet.TabIndex = 9;
            this.lblAdet.Text = "Adet:";
            // 
            // txtBoxFiyat
            // 
            this.txtBoxFiyat.Location = new System.Drawing.Point(92, 114);
            this.txtBoxFiyat.Name = "txtBoxFiyat";
            this.txtBoxFiyat.Size = new System.Drawing.Size(150, 20);
            this.txtBoxFiyat.TabIndex = 8;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblFiyat.Location = new System.Drawing.Point(44, 115);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(41, 15);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtBoxMusteri
            // 
            this.txtBoxMusteri.Location = new System.Drawing.Point(91, 36);
            this.txtBoxMusteri.Name = "txtBoxMusteri";
            this.txtBoxMusteri.Size = new System.Drawing.Size(150, 20);
            this.txtBoxMusteri.TabIndex = 6;
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblMusteri.Location = new System.Drawing.Point(26, 37);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(59, 15);
            this.lblMusteri.TabIndex = 5;
            this.lblMusteri.Text = "Müşteri:";
            // 
            // txtBoxMusteriID
            // 
            this.txtBoxMusteriID.Location = new System.Drawing.Point(91, 11);
            this.txtBoxMusteriID.Name = "txtBoxMusteriID";
            this.txtBoxMusteriID.Size = new System.Drawing.Size(150, 20);
            this.txtBoxMusteriID.TabIndex = 4;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblMusteriID.Location = new System.Drawing.Point(8, 12);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(77, 15);
            this.lblMusteriID.TabIndex = 2;
            this.lblMusteriID.Text = "Müşteri ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.txtBoxToplam);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.lblToplam);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.lblUrun);
            this.groupBox1.Controls.Add(this.txtBoxAdet);
            this.groupBox1.Controls.Add(this.lblAdet);
            this.groupBox1.Controls.Add(this.txtBoxFiyat);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.txtBoxMusteri);
            this.groupBox1.Controls.Add(this.lblMusteri);
            this.groupBox1.Controls.Add(this.txtBoxMusteriID);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Location = new System.Drawing.Point(627, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 350);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(92, 166);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(149, 20);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxToplam
            // 
            this.txtBoxToplam.Location = new System.Drawing.Point(91, 140);
            this.txtBoxToplam.Name = "txtBoxToplam";
            this.txtBoxToplam.Size = new System.Drawing.Size(150, 20);
            this.txtBoxToplam.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTarih.Location = new System.Drawing.Point(41, 169);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(44, 15);
            this.lblTarih.TabIndex = 21;
            this.lblTarih.Text = "Tarih:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 350);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSatis";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.TextBox txtBoxAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txtBoxFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtBoxMusteri;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.TextBox txtBoxMusteriID;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxToplam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}