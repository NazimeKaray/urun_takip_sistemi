namespace ÜRÜN_TAKİP_SİSTEMİ
{
    partial class frmMusteri
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.txtBoxSehir = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.txtBoxBakiye = new System.Windows.Forms.TextBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtBoxMusteriAd = new System.Windows.Forms.TextBox();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.txtBoxMusteriID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxMusteriSoyad = new System.Windows.Forms.TextBox();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.radioBtnSehir = new System.Windows.Forms.RadioButton();
            this.radioBtnSoyad = new System.Windows.Forms.RadioButton();
            this.radioBtnAd = new System.Windows.Forms.RadioButton();
            this.txtBoxKelime = new System.Windows.Forms.TextBox();
            this.lblKelime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(91, 154);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(150, 36);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(91, 196);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 36);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "EKLE";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(91, 280);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 36);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(91, 238);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 36);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 287);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyad.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(24, 64);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(61, 15);
            this.lblMusteriSoyad.TabIndex = 11;
            this.lblMusteriSoyad.Text = "Soyisim:";
            // 
            // txtBoxSehir
            // 
            this.txtBoxSehir.Location = new System.Drawing.Point(91, 89);
            this.txtBoxSehir.Name = "txtBoxSehir";
            this.txtBoxSehir.Size = new System.Drawing.Size(150, 20);
            this.txtBoxSehir.TabIndex = 4;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblSehir.Location = new System.Drawing.Point(40, 90);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(45, 15);
            this.lblSehir.TabIndex = 9;
            this.lblSehir.Text = "Şehir:";
            // 
            // txtBoxBakiye
            // 
            this.txtBoxBakiye.Location = new System.Drawing.Point(91, 115);
            this.txtBoxBakiye.Name = "txtBoxBakiye";
            this.txtBoxBakiye.Size = new System.Drawing.Size(150, 20);
            this.txtBoxBakiye.TabIndex = 5;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblBakiye.Location = new System.Drawing.Point(36, 116);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(49, 15);
            this.lblBakiye.TabIndex = 7;
            this.lblBakiye.Text = "Bakiye";
            // 
            // txtBoxMusteriAd
            // 
            this.txtBoxMusteriAd.Location = new System.Drawing.Point(91, 37);
            this.txtBoxMusteriAd.Name = "txtBoxMusteriAd";
            this.txtBoxMusteriAd.Size = new System.Drawing.Size(150, 20);
            this.txtBoxMusteriAd.TabIndex = 2;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblMusteriAd.Location = new System.Drawing.Point(47, 38);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(38, 15);
            this.lblMusteriAd.TabIndex = 5;
            this.lblMusteriAd.Text = "İsim:";
            // 
            // txtBoxMusteriID
            // 
            this.txtBoxMusteriID.Location = new System.Drawing.Point(91, 12);
            this.txtBoxMusteriID.Name = "txtBoxMusteriID";
            this.txtBoxMusteriID.Size = new System.Drawing.Size(150, 20);
            this.txtBoxMusteriID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxMusteriSoyad);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.lblMusteriSoyad);
            this.groupBox1.Controls.Add(this.txtBoxSehir);
            this.groupBox1.Controls.Add(this.lblSehir);
            this.groupBox1.Controls.Add(this.txtBoxBakiye);
            this.groupBox1.Controls.Add(this.lblBakiye);
            this.groupBox1.Controls.Add(this.txtBoxMusteriAd);
            this.groupBox1.Controls.Add(this.lblMusteriAd);
            this.groupBox1.Controls.Add(this.txtBoxMusteriID);
            this.groupBox1.Controls.Add(this.lblMusteriID);
            this.groupBox1.Location = new System.Drawing.Point(627, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtBoxMusteriSoyad
            // 
            this.txtBoxMusteriSoyad.Location = new System.Drawing.Point(91, 63);
            this.txtBoxMusteriSoyad.Name = "txtBoxMusteriSoyad";
            this.txtBoxMusteriSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtBoxMusteriSoyad.TabIndex = 3;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblMusteriID.Location = new System.Drawing.Point(8, 13);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(77, 15);
            this.lblMusteriID.TabIndex = 2;
            this.lblMusteriID.Text = "Müşteri ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.radioBtnSehir);
            this.groupBox2.Controls.Add(this.radioBtnSoyad);
            this.groupBox2.Controls.Add(this.radioBtnAd);
            this.groupBox2.Controls.Add(this.txtBoxKelime);
            this.groupBox2.Controls.Add(this.lblKelime);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(497, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(76, 30);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // radioBtnSehir
            // 
            this.radioBtnSehir.AutoSize = true;
            this.radioBtnSehir.Location = new System.Drawing.Point(429, 19);
            this.radioBtnSehir.Name = "radioBtnSehir";
            this.radioBtnSehir.Size = new System.Drawing.Size(49, 17);
            this.radioBtnSehir.TabIndex = 25;
            this.radioBtnSehir.TabStop = true;
            this.radioBtnSehir.Text = "Sehir";
            this.radioBtnSehir.UseVisualStyleBackColor = true;
            // 
            // radioBtnSoyad
            // 
            this.radioBtnSoyad.AutoSize = true;
            this.radioBtnSoyad.Location = new System.Drawing.Point(363, 19);
            this.radioBtnSoyad.Name = "radioBtnSoyad";
            this.radioBtnSoyad.Size = new System.Drawing.Size(60, 17);
            this.radioBtnSoyad.TabIndex = 24;
            this.radioBtnSoyad.TabStop = true;
            this.radioBtnSoyad.Text = "Soyisim";
            this.radioBtnSoyad.UseVisualStyleBackColor = true;
            // 
            // radioBtnAd
            // 
            this.radioBtnAd.AutoSize = true;
            this.radioBtnAd.Location = new System.Drawing.Point(314, 19);
            this.radioBtnAd.Name = "radioBtnAd";
            this.radioBtnAd.Size = new System.Drawing.Size(43, 17);
            this.radioBtnAd.TabIndex = 23;
            this.radioBtnAd.TabStop = true;
            this.radioBtnAd.Text = "İsim";
            this.radioBtnAd.UseVisualStyleBackColor = true;
            // 
            // txtBoxKelime
            // 
            this.txtBoxKelime.Location = new System.Drawing.Point(131, 18);
            this.txtBoxKelime.Name = "txtBoxKelime";
            this.txtBoxKelime.Size = new System.Drawing.Size(162, 20);
            this.txtBoxKelime.TabIndex = 21;
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblKelime.Location = new System.Drawing.Point(6, 19);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(119, 15);
            this.lblKelime.TabIndex = 22;
            this.lblKelime.Text = "Aranacak Kelime:";
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteri";
            this.Text = "frmMusteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.TextBox txtBoxSehir;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox txtBoxBakiye;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtBoxMusteriAd;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox txtBoxMusteriID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton radioBtnSehir;
        private System.Windows.Forms.RadioButton radioBtnSoyad;
        private System.Windows.Forms.RadioButton radioBtnAd;
        private System.Windows.Forms.TextBox txtBoxKelime;
        private System.Windows.Forms.Label lblKelime;
    }
}