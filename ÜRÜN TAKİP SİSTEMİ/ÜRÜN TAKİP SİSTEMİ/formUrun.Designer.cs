namespace ÜRÜN_TAKİP_SİSTEMİ
{
    partial class formUrun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListeleF2 = new System.Windows.Forms.Button();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblKategoriF2 = new System.Windows.Forms.Label();
            this.btnKaydetF2 = new System.Windows.Forms.Button();
            this.btnGuncelleF2 = new System.Windows.Forms.Button();
            this.btnSilF2 = new System.Windows.Forms.Button();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtBoxAlis = new System.Windows.Forms.TextBox();
            this.lblAlis = new System.Windows.Forms.Label();
            this.txtBoxSatis = new System.Windows.Forms.TextBox();
            this.lblSatis = new System.Windows.Forms.Label();
            this.txtBoxUrnIsmi = new System.Windows.Forms.TextBox();
            this.lblUrnIsmi = new System.Windows.Forms.Label();
            this.txtBoxUrunID = new System.Windows.Forms.TextBox();
            this.lblUrunID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 337);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListeleF2);
            this.groupBox1.Controls.Add(this.nudStok);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblKategoriF2);
            this.groupBox1.Controls.Add(this.btnKaydetF2);
            this.groupBox1.Controls.Add(this.btnGuncelleF2);
            this.groupBox1.Controls.Add(this.btnSilF2);
            this.groupBox1.Controls.Add(this.lblStok);
            this.groupBox1.Controls.Add(this.txtBoxAlis);
            this.groupBox1.Controls.Add(this.lblAlis);
            this.groupBox1.Controls.Add(this.txtBoxSatis);
            this.groupBox1.Controls.Add(this.lblSatis);
            this.groupBox1.Controls.Add(this.txtBoxUrnIsmi);
            this.groupBox1.Controls.Add(this.lblUrnIsmi);
            this.groupBox1.Controls.Add(this.txtBoxUrunID);
            this.groupBox1.Controls.Add(this.lblUrunID);
            this.groupBox1.Location = new System.Drawing.Point(627, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnListeleF2
            // 
            this.btnListeleF2.Location = new System.Drawing.Point(91, 177);
            this.btnListeleF2.Name = "btnListeleF2";
            this.btnListeleF2.Size = new System.Drawing.Size(150, 36);
            this.btnListeleF2.TabIndex = 19;
            this.btnListeleF2.Text = "LİSTELE";
            this.btnListeleF2.UseVisualStyleBackColor = true;
            this.btnListeleF2.Click += new System.EventHandler(this.btnListeleF2_Click);
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(91, 64);
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(150, 20);
            this.nudStok.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Tag = "comBoxKategori";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblKategoriF2
            // 
            this.lblKategoriF2.AutoSize = true;
            this.lblKategoriF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriF2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblKategoriF2.Location = new System.Drawing.Point(22, 142);
            this.lblKategoriF2.Name = "lblKategoriF2";
            this.lblKategoriF2.Size = new System.Drawing.Size(65, 15);
            this.lblKategoriF2.TabIndex = 17;
            this.lblKategoriF2.Text = "Kategori:";
            // 
            // btnKaydetF2
            // 
            this.btnKaydetF2.Location = new System.Drawing.Point(91, 219);
            this.btnKaydetF2.Name = "btnKaydetF2";
            this.btnKaydetF2.Size = new System.Drawing.Size(150, 36);
            this.btnKaydetF2.TabIndex = 16;
            this.btnKaydetF2.Text = "KAYDET";
            this.btnKaydetF2.UseVisualStyleBackColor = true;
            this.btnKaydetF2.Click += new System.EventHandler(this.btnKaydetF2_Click);
            // 
            // btnGuncelleF2
            // 
            this.btnGuncelleF2.Location = new System.Drawing.Point(91, 303);
            this.btnGuncelleF2.Name = "btnGuncelleF2";
            this.btnGuncelleF2.Size = new System.Drawing.Size(150, 36);
            this.btnGuncelleF2.TabIndex = 15;
            this.btnGuncelleF2.Text = "GÜNCELLE";
            this.btnGuncelleF2.UseVisualStyleBackColor = true;
            this.btnGuncelleF2.Click += new System.EventHandler(this.btnGuncelleF2_Click);
            // 
            // btnSilF2
            // 
            this.btnSilF2.Location = new System.Drawing.Point(91, 261);
            this.btnSilF2.Name = "btnSilF2";
            this.btnSilF2.Size = new System.Drawing.Size(150, 36);
            this.btnSilF2.TabIndex = 14;
            this.btnSilF2.Text = "SİL";
            this.btnSilF2.UseVisualStyleBackColor = true;
            this.btnSilF2.Click += new System.EventHandler(this.btnSilF2_Click);
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStok.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblStok.Location = new System.Drawing.Point(48, 64);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(39, 15);
            this.lblStok.TabIndex = 11;
            this.lblStok.Text = "Stok:";
            // 
            // txtBoxAlis
            // 
            this.txtBoxAlis.Location = new System.Drawing.Point(91, 89);
            this.txtBoxAlis.Name = "txtBoxAlis";
            this.txtBoxAlis.Size = new System.Drawing.Size(150, 20);
            this.txtBoxAlis.TabIndex = 10;
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlis.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblAlis.Location = new System.Drawing.Point(15, 90);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(72, 15);
            this.lblAlis.TabIndex = 9;
            this.lblAlis.Text = "Alış Fiyatı:";
            // 
            // txtBoxSatis
            // 
            this.txtBoxSatis.Location = new System.Drawing.Point(91, 115);
            this.txtBoxSatis.Name = "txtBoxSatis";
            this.txtBoxSatis.Size = new System.Drawing.Size(150, 20);
            this.txtBoxSatis.TabIndex = 8;
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatis.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblSatis.Location = new System.Drawing.Point(6, 116);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(81, 15);
            this.lblSatis.TabIndex = 7;
            this.lblSatis.Text = "Satış Fiyatı:";
            // 
            // txtBoxUrnIsmi
            // 
            this.txtBoxUrnIsmi.Location = new System.Drawing.Point(91, 37);
            this.txtBoxUrnIsmi.Name = "txtBoxUrnIsmi";
            this.txtBoxUrnIsmi.Size = new System.Drawing.Size(150, 20);
            this.txtBoxUrnIsmi.TabIndex = 6;
            this.txtBoxUrnIsmi.TextChanged += new System.EventHandler(this.txtBoxUrnIsmi_TextChanged);
            // 
            // lblUrnIsmi
            // 
            this.lblUrnIsmi.AutoSize = true;
            this.lblUrnIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrnIsmi.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblUrnIsmi.Location = new System.Drawing.Point(14, 38);
            this.lblUrnIsmi.Name = "lblUrnIsmi";
            this.lblUrnIsmi.Size = new System.Drawing.Size(73, 15);
            this.lblUrnIsmi.TabIndex = 5;
            this.lblUrnIsmi.Text = "Ürün İsmi:";
            // 
            // txtBoxUrunID
            // 
            this.txtBoxUrunID.Location = new System.Drawing.Point(91, 12);
            this.txtBoxUrunID.Name = "txtBoxUrunID";
            this.txtBoxUrunID.Size = new System.Drawing.Size(150, 20);
            this.txtBoxUrunID.TabIndex = 4;
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunID.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblUrunID.Location = new System.Drawing.Point(27, 13);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(60, 15);
            this.lblUrunID.TabIndex = 2;
            this.lblUrunID.Text = "Ürün ID:";
            this.lblUrunID.Click += new System.EventHandler(this.lblKategori_Click);
            // 
            // formUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUrun";
            this.Load += new System.EventHandler(this.formUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtBoxAlis;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.TextBox txtBoxSatis;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.TextBox txtBoxUrnIsmi;
        private System.Windows.Forms.Label lblUrnIsmi;
        private System.Windows.Forms.TextBox txtBoxUrunID;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.Button btnKaydetF2;
        private System.Windows.Forms.Button btnGuncelleF2;
        private System.Windows.Forms.Button btnSilF2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblKategoriF2;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Button btnListeleF2;
    }
}