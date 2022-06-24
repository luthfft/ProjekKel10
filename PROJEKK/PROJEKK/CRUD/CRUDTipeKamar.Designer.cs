namespace PROJEKK
{
    partial class CRUDTipeKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDTipeKamar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.tblTipeKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLuas = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtidKamar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnupadate = new ns1.BunifuThinButton2();
            this.btndelete = new ns1.BunifuThinButton2();
            this.btnSave = new ns1.BunifuThinButton2();
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgridKamar = new ns1.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipeKamarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Penuh"});
            this.cmbStatus.Location = new System.Drawing.Point(270, 363);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 24);
            this.cmbStatus.TabIndex = 44;
            // 
            // tblTipeKamarBindingSource
            // 
            this.tblTipeKamarBindingSource.DataMember = "tblTipeKamar";
            // 
            // txtLuas
            // 
            this.txtLuas.Location = new System.Drawing.Point(270, 230);
            this.txtLuas.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuas.Name = "txtLuas";
            this.txtLuas.Size = new System.Drawing.Size(160, 22);
            this.txtLuas.TabIndex = 37;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(270, 288);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(160, 22);
            this.txtHarga.TabIndex = 36;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(270, 164);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(160, 22);
            this.txtdesc.TabIndex = 35;
            // 
            // txtidKamar
            // 
            this.txtidKamar.Location = new System.Drawing.Point(270, 102);
            this.txtidKamar.Margin = new System.Windows.Forms.Padding(4);
            this.txtidKamar.Name = "txtidKamar";
            this.txtidKamar.Size = new System.Drawing.Size(160, 22);
            this.txtidKamar.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(96, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Status Ketersediaan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(96, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Deskripsi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Luas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "IdKamar";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::PROJEKK.Properties.Resources.icons8_search_30;
            this.btnSearch.Location = new System.Drawing.Point(963, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 42);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnupadate
            // 
            this.btnupadate.ActiveBorderThickness = 1;
            this.btnupadate.ActiveCornerRadius = 20;
            this.btnupadate.ActiveFillColor = System.Drawing.Color.MintCream;
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
            this.btnupadate.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnupadate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnupadate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnupadate.Location = new System.Drawing.Point(222, 614);
            this.btnupadate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupadate.Name = "btnupadate";
            this.btnupadate.Size = new System.Drawing.Size(139, 42);
            this.btnupadate.TabIndex = 42;
            this.btnupadate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupadate.Click += new System.EventHandler(this.btnupadate_Click);
            // 
            // btndelete
            // 
            this.btndelete.ActiveBorderThickness = 1;
            this.btndelete.ActiveCornerRadius = 20;
            this.btndelete.ActiveFillColor = System.Drawing.Color.MintCream;
            this.btndelete.ActiveForecolor = System.Drawing.Color.White;
            this.btndelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.ButtonText = "DELETE";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.btndelete.IdleBorderThickness = 1;
            this.btndelete.IdleCornerRadius = 20;
            this.btndelete.IdleFillColor = System.Drawing.Color.White;
            this.btndelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Location = new System.Drawing.Point(399, 614);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 42);
            this.btndelete.TabIndex = 41;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.MintCream;
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
            this.btnSave.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(52, 614);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 40;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.tbSearch.Location = new System.Drawing.Point(793, 50);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(163, 44);
            this.tbSearch.TabIndex = 46;
            this.tbSearch.Text = "Cari";
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.dgridKamar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnupadate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.txtidKamar);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtdesc);
            this.panel1.Controls.Add(this.txtHarga);
            this.panel1.Controls.Add(this.txtLuas);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 675);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgridKamar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridKamar.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgridKamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridKamar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKamar.DoubleBuffered = true;
            this.dgridKamar.EnableHeadersVisualStyles = false;
            this.dgridKamar.HeaderBgColor = System.Drawing.Color.Silver;
            this.dgridKamar.HeaderForeColor = System.Drawing.Color.Black;
            this.dgridKamar.Location = new System.Drawing.Point(451, 106);
            this.dgridKamar.Name = "dgridKamar";
            this.dgridKamar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridKamar.RowTemplate.Height = 24;
            this.dgridKamar.Size = new System.Drawing.Size(549, 432);
            this.dgridKamar.TabIndex = 47;
            this.dgridKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridKamar_CellClick);
            // 
            // CRUDTipeKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1025, 737);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDTipeKamar";
            this.Text = "MASTER TIPE KAMAR";
            this.Load += new System.EventHandler(this.CRUDTipeKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTipeKamarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKamar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private ns1.BunifuThinButton2 btnupadate;
        private ns1.BunifuThinButton2 btndelete;
        private ns1.BunifuThinButton2 btnSave;
        private System.Windows.Forms.BindingSource tblTipeKamarBindingSource;
        private System.Windows.Forms.TextBox txtLuas;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtidKamar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox tbSearch;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomDataGrid dgridKamar;
    }
}