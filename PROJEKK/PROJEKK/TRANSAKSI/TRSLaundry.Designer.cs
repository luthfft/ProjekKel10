namespace PROJEKK.TRANSAKSI
{
    partial class TRSLaundry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRSLaundry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHitung = new ns1.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbHarTot = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgridLoadLaundry = new System.Windows.Forms.DataGridView();
            this.btnTambah = new ns1.BunifuThinButton2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new ns1.BunifuThinButton2();
            this.dgridtrsLaundry = new ns1.BunifuCustomDataGrid();
            this.idKaryawan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPenyewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_trsLaundry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tl_total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPakaian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbidLaundry = new System.Windows.Forms.TextBox();
            this.tbIdtrs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridLoadLaundry)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridtrsLaundry)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHitung
            // 
            this.btnHitung.ActiveBorderThickness = 1;
            this.btnHitung.ActiveCornerRadius = 20;
            this.btnHitung.ActiveFillColor = System.Drawing.Color.Black;
            this.btnHitung.ActiveForecolor = System.Drawing.Color.Black;
            this.btnHitung.ActiveLineColor = System.Drawing.Color.Black;
            this.btnHitung.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHitung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHitung.BackgroundImage")));
            this.btnHitung.ButtonText = "Hitung";
            this.btnHitung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHitung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitung.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHitung.IdleBorderThickness = 1;
            this.btnHitung.IdleCornerRadius = 20;
            this.btnHitung.IdleFillColor = System.Drawing.Color.Black;
            this.btnHitung.IdleForecolor = System.Drawing.Color.White;
            this.btnHitung.IdleLineColor = System.Drawing.Color.Black;
            this.btnHitung.Location = new System.Drawing.Point(387, 438);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(5);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(92, 35);
            this.btnHitung.TabIndex = 48;
            this.btnHitung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Per KG";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(123, 158);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(172, 22);
            this.tbHarga.TabIndex = 35;
            // 
            // tbHarTot
            // 
            this.tbHarTot.Location = new System.Drawing.Point(192, 516);
            this.tbHarTot.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarTot.Name = "tbHarTot";
            this.tbHarTot.Size = new System.Drawing.Size(172, 22);
            this.tbHarTot.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.btnHitung);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.tbHarTot);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbBerat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 750);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox4.Controls.Add(this.dgridLoadLaundry);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(587, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(676, 180);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Laundry";
            // 
            // dgridLoadLaundry
            // 
            this.dgridLoadLaundry.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgridLoadLaundry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridLoadLaundry.Location = new System.Drawing.Point(18, 29);
            this.dgridLoadLaundry.Name = "dgridLoadLaundry";
            this.dgridLoadLaundry.RowTemplate.Height = 24;
            this.dgridLoadLaundry.Size = new System.Drawing.Size(631, 119);
            this.dgridLoadLaundry.TabIndex = 0;
            this.dgridLoadLaundry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridLoadLaundry_CellClick_2);
            // 
            // btnTambah
            // 
            this.btnTambah.ActiveBorderThickness = 1;
            this.btnTambah.ActiveCornerRadius = 20;
            this.btnTambah.ActiveFillColor = System.Drawing.Color.Black;
            this.btnTambah.ActiveForecolor = System.Drawing.Color.Black;
            this.btnTambah.ActiveLineColor = System.Drawing.Color.Black;
            this.btnTambah.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTambah.BackgroundImage")));
            this.btnTambah.ButtonText = "TAMBAH";
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTambah.IdleBorderThickness = 1;
            this.btnTambah.IdleCornerRadius = 20;
            this.btnTambah.IdleFillColor = System.Drawing.Color.Black;
            this.btnTambah.IdleForecolor = System.Drawing.Color.White;
            this.btnTambah.IdleLineColor = System.Drawing.Color.Black;
            this.btnTambah.Location = new System.Drawing.Point(387, 505);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(5);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(108, 33);
            this.btnTambah.TabIndex = 49;
            this.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.dgridtrsLaundry);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(587, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 204);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keranjang";
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.Black;
            this.btnSave.ActiveForecolor = System.Drawing.Color.Black;
            this.btnSave.ActiveLineColor = System.Drawing.Color.Black;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "BAYAR";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.Black;
            this.btnSave.IdleForecolor = System.Drawing.Color.White;
            this.btnSave.IdleLineColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(532, 149);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 47);
            this.btnSave.TabIndex = 59;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgridtrsLaundry
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridtrsLaundry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgridtrsLaundry.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgridtrsLaundry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridtrsLaundry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridtrsLaundry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgridtrsLaundry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridtrsLaundry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKaryawan,
            this.idPenyewa,
            this.tgl_trsLaundry,
            this.tl_total_harga});
            this.dgridtrsLaundry.DoubleBuffered = true;
            this.dgridtrsLaundry.EnableHeadersVisualStyles = false;
            this.dgridtrsLaundry.HeaderBgColor = System.Drawing.Color.Silver;
            this.dgridtrsLaundry.HeaderForeColor = System.Drawing.Color.Black;
            this.dgridtrsLaundry.Location = new System.Drawing.Point(18, 21);
            this.dgridtrsLaundry.Name = "dgridtrsLaundry";
            this.dgridtrsLaundry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridtrsLaundry.RowTemplate.Height = 24;
            this.dgridtrsLaundry.Size = new System.Drawing.Size(631, 120);
            this.dgridtrsLaundry.TabIndex = 46;
            this.dgridtrsLaundry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridLaundry_CellContentClick);
            // 
            // idKaryawan
            // 
            this.idKaryawan.DataPropertyName = "idKaryawan";
            this.idKaryawan.HeaderText = "idKaryawan";
            this.idKaryawan.Name = "idKaryawan";
            // 
            // idPenyewa
            // 
            this.idPenyewa.DataPropertyName = "idPenyewa";
            this.idPenyewa.HeaderText = "idPenyewa";
            this.idPenyewa.Name = "idPenyewa";
            // 
            // tgl_trsLaundry
            // 
            this.tgl_trsLaundry.DataPropertyName = "tgl_trsLaundry";
            this.tgl_trsLaundry.HeaderText = "tgl_trsLaundry";
            this.tgl_trsLaundry.Name = "tgl_trsLaundry";
            // 
            // tl_total_harga
            // 
            this.tl_total_harga.DataPropertyName = "tl_total_harga";
            this.tl_total_harga.HeaderText = "tl_total_harga";
            this.tl_total_harga.Name = "tl_total_harga";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHarga);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPakaian);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbidLaundry);
            this.groupBox2.Controls.Add(this.tbIdtrs);
            this.groupBox2.Location = new System.Drawing.Point(69, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 214);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id Laundry";
            // 
            // tbPakaian
            // 
            this.tbPakaian.Location = new System.Drawing.Point(123, 114);
            this.tbPakaian.Margin = new System.Windows.Forms.Padding(4);
            this.tbPakaian.Name = "tbPakaian";
            this.tbPakaian.Size = new System.Drawing.Size(172, 22);
            this.tbPakaian.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Id TrsLaundry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Pakaian";
            // 
            // tbidLaundry
            // 
            this.tbidLaundry.Location = new System.Drawing.Point(123, 74);
            this.tbidLaundry.Margin = new System.Windows.Forms.Padding(4);
            this.tbidLaundry.Name = "tbidLaundry";
            this.tbidLaundry.Size = new System.Drawing.Size(172, 22);
            this.tbidLaundry.TabIndex = 34;
            // 
            // tbIdtrs
            // 
            this.tbIdtrs.Location = new System.Drawing.Point(123, 29);
            this.tbIdtrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdtrs.Name = "tbIdtrs";
            this.tbIdtrs.Size = new System.Drawing.Size(172, 22);
            this.tbIdtrs.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(92, 519);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Harga Total";
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(192, 451);
            this.tbBerat.Margin = new System.Windows.Forms.Padding(4);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(172, 22);
            this.tbBerat.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 454);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Berat";
            // 
            // TRSLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1342, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TRSLaundry";
            this.Text = "TRANSAKSI LAUNDRY";
            this.Load += new System.EventHandler(this.TRSLaundry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridLoadLaundry)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridtrsLaundry)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 btnHitung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbHarTot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdtrs;
        private System.Windows.Forms.TextBox tbPakaian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCustomDataGrid dgridtrsLaundry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbidLaundry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private ns1.BunifuThinButton2 btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKaryawan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPenyewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_trsLaundry;
        private System.Windows.Forms.DataGridViewTextBoxColumn tl_total_harga;
        private System.Windows.Forms.GroupBox groupBox4;
        private ns1.BunifuThinButton2 btnSave;
        private System.Windows.Forms.DataGridView dgridLoadLaundry;
    }
}