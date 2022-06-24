namespace PROJEKK
{
    partial class CRUDFasilitas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDFasilitas));
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbidFasilitas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.dgridFasil = new ns1.BunifuCustomDataGrid();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnupadate = new ns1.BunifuThinButton2();
            this.btndelete = new ns1.BunifuThinButton2();
            this.btnSave = new ns1.BunifuThinButton2();
            this.tblFasilitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgridFasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFasilitasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(157, 151);
            this.tbDeskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(187, 66);
            this.tbDeskripsi.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Deskripsi";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(157, 251);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(187, 22);
            this.tbHarga.TabIndex = 35;
            // 
            // tbidFasilitas
            // 
            this.tbidFasilitas.Location = new System.Drawing.Point(157, 102);
            this.tbidFasilitas.Margin = new System.Windows.Forms.Padding(4);
            this.tbidFasilitas.Name = "tbidFasilitas";
            this.tbidFasilitas.Size = new System.Drawing.Size(187, 22);
            this.tbidFasilitas.TabIndex = 34;
            this.tbidFasilitas.TextChanged += new System.EventHandler(this.tbidFasilitas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-6, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id Fasilitas";
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearch.HintText = "";
            this.tbSearch.isPassword = false;
            this.tbSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearch.LineThickness = 3;
            this.tbSearch.Location = new System.Drawing.Point(428, 229);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(163, 44);
            this.tbSearch.TabIndex = 45;
            this.tbSearch.Text = "Cari";
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgridFasil
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridFasil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridFasil.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgridFasil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridFasil.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridFasil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridFasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridFasil.DoubleBuffered = true;
            this.dgridFasil.EnableHeadersVisualStyles = false;
            this.dgridFasil.HeaderBgColor = System.Drawing.Color.Silver;
            this.dgridFasil.HeaderForeColor = System.Drawing.Color.Black;
            this.dgridFasil.Location = new System.Drawing.Point(9, 325);
            this.dgridFasil.Name = "dgridFasil";
            this.dgridFasil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridFasil.RowTemplate.Height = 24;
            this.dgridFasil.Size = new System.Drawing.Size(780, 263);
            this.dgridFasil.TabIndex = 46;
            this.dgridFasil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridFasil_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::PROJEKK.Properties.Resources.icons8_search_30;
            this.btnSearch.Location = new System.Drawing.Point(585, 231);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 42);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnupadate
            // 
            this.btnupadate.ActiveBorderThickness = 1;
            this.btnupadate.ActiveCornerRadius = 20;
            this.btnupadate.ActiveFillColor = System.Drawing.Color.PaleGreen;
            this.btnupadate.ActiveForecolor = System.Drawing.Color.White;
            this.btnupadate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnupadate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnupadate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupadate.BackgroundImage")));
            this.btnupadate.ButtonText = "UPDATE";
            this.btnupadate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupadate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupadate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnupadate.IdleBorderThickness = 1;
            this.btnupadate.IdleCornerRadius = 20;
            this.btnupadate.IdleFillColor = System.Drawing.Color.White;
            this.btnupadate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnupadate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnupadate.Location = new System.Drawing.Point(176, 614);
            this.btnupadate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupadate.Name = "btnupadate";
            this.btnupadate.Size = new System.Drawing.Size(139, 42);
            this.btnupadate.TabIndex = 43;
            this.btnupadate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupadate.Click += new System.EventHandler(this.btnupadate_Click);
            // 
            // btndelete
            // 
            this.btndelete.ActiveBorderThickness = 1;
            this.btndelete.ActiveCornerRadius = 20;
            this.btndelete.ActiveFillColor = System.Drawing.Color.Lime;
            this.btndelete.ActiveForecolor = System.Drawing.Color.White;
            this.btndelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.ButtonText = "DELETE";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleBorderThickness = 1;
            this.btndelete.IdleCornerRadius = 20;
            this.btndelete.IdleFillColor = System.Drawing.Color.White;
            this.btndelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Location = new System.Drawing.Point(348, 614);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 42);
            this.btndelete.TabIndex = 42;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(12, 614);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 41;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblFasilitasBindingSource
            // 
            this.tblFasilitasBindingSource.DataMember = "tblFasilitas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgridFasil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbidFasilitas);
            this.panel1.Controls.Add(this.btnupadate);
            this.panel1.Controls.Add(this.tbHarga);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbDeskripsi);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 655);
            this.panel1.TabIndex = 47;
            // 
            // CRUDFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(804, 670);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDFasilitas";
            this.Text = "MASTER LAUNDRY";
            this.Load += new System.EventHandler(this.CRUDFasilitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridFasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFasilitasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblFasilitasBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private ns1.BunifuThinButton2 btnupadate;
        private ns1.BunifuThinButton2 btndelete;
        private ns1.BunifuThinButton2 btnSave;
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbidFasilitas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox tbSearch;
        private ns1.BunifuCustomDataGrid dgridFasil;
        private System.Windows.Forms.Panel panel1;
    }
}