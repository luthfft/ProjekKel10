namespace PROJEKK.CRUD
{
    partial class CRUDPenyewa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDPenyewa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridcrudpenyewa = new ns1.BunifuCustomDataGrid();
            this.tblRoleKaryawanTableAdapter = new PROJEKK.PRG2_KEL10DataSet1TableAdapters.tblRoleKaryawanTableAdapter();
            this.pRG2_KEL10DataSet = new PROJEKK.PRG2_KEL10DataSet();
            this.pRG2_KEL10DataSet1 = new PROJEKK.PRG2_KEL10DataSet1();
            this.tblRoleKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbIdpenyewa = new System.Windows.Forms.TextBox();
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.btnupadate = new ns1.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.btndelete = new ns1.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new ns1.BunifuThinButton2();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnik = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridcrudpenyewa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleKaryawanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tbnik);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgridcrudpenyewa);
            this.panel1.Controls.Add(this.tbIdpenyewa);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbnama);
            this.panel1.Controls.Add(this.btnupadate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbalamat);
            this.panel1.Controls.Add(this.tbNoTelp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 728);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Penyewa";
            // 
            // dgridcrudpenyewa
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridcrudpenyewa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgridcrudpenyewa.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgridcrudpenyewa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridcrudpenyewa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridcrudpenyewa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgridcrudpenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridcrudpenyewa.DoubleBuffered = true;
            this.dgridcrudpenyewa.EnableHeadersVisualStyles = false;
            this.dgridcrudpenyewa.HeaderBgColor = System.Drawing.Color.Silver;
            this.dgridcrudpenyewa.HeaderForeColor = System.Drawing.Color.Black;
            this.dgridcrudpenyewa.Location = new System.Drawing.Point(424, 112);
            this.dgridcrudpenyewa.Name = "dgridcrudpenyewa";
            this.dgridcrudpenyewa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridcrudpenyewa.RowTemplate.Height = 24;
            this.dgridcrudpenyewa.Size = new System.Drawing.Size(969, 423);
            this.dgridcrudpenyewa.TabIndex = 43;
            // 
            // tblRoleKaryawanTableAdapter
            // 
            this.tblRoleKaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // pRG2_KEL10DataSet
            // 
            this.pRG2_KEL10DataSet.DataSetName = "PRG2_KEL10DataSet";
            this.pRG2_KEL10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRG2_KEL10DataSet1
            // 
            this.pRG2_KEL10DataSet1.DataSetName = "PRG2_KEL10DataSet1";
            this.pRG2_KEL10DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoleKaryawanBindingSource
            // 
            this.tblRoleKaryawanBindingSource.DataMember = "tblRoleKaryawan";
            this.tblRoleKaryawanBindingSource.DataSource = this.pRG2_KEL10DataSet1;
            // 
            // tbIdpenyewa
            // 
            this.tbIdpenyewa.Location = new System.Drawing.Point(142, 111);
            this.tbIdpenyewa.Name = "tbIdpenyewa";
            this.tbIdpenyewa.Size = new System.Drawing.Size(163, 22);
            this.tbIdpenyewa.TabIndex = 24;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.HintForeColor = System.Drawing.Color.White;
            this.tbSearch.HintText = "Cari";
            this.tbSearch.isPassword = false;
            this.tbSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearch.LineThickness = 3;
            this.tbSearch.Location = new System.Drawing.Point(1046, 60);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(163, 44);
            this.tbSearch.TabIndex = 42;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(33, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Alamat";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1201, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 42);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(142, 255);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(248, 22);
            this.tbnama.TabIndex = 27;
            // 
            // btnupadate
            // 
            this.btnupadate.ActiveBorderThickness = 1;
            this.btnupadate.ActiveCornerRadius = 20;
            this.btnupadate.ActiveFillColor = System.Drawing.Color.ForestGreen;
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
            this.btnupadate.Location = new System.Drawing.Point(210, 622);
            this.btnupadate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupadate.Name = "btnupadate";
            this.btnupadate.Size = new System.Drawing.Size(139, 42);
            this.btnupadate.TabIndex = 40;
            this.btnupadate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupadate.Click += new System.EventHandler(this.btnupadate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(33, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nama";
            // 
            // btndelete
            // 
            this.btndelete.ActiveBorderThickness = 1;
            this.btndelete.ActiveCornerRadius = 20;
            this.btndelete.ActiveFillColor = System.Drawing.Color.DarkGreen;
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
            this.btndelete.Location = new System.Drawing.Point(374, 622);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 42);
            this.btndelete.TabIndex = 39;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "NIK";
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.ForestGreen;
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
            this.btnSave.Location = new System.Drawing.Point(49, 622);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 38;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(142, 413);
            this.tbalamat.Multiline = true;
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(248, 92);
            this.tbalamat.TabIndex = 31;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Location = new System.Drawing.Point(142, 325);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(163, 22);
            this.tbNoTelp.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(33, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "No Telepon";
            // 
            // tbnik
            // 
            this.tbnik.Location = new System.Drawing.Point(142, 188);
            this.tbnik.Name = "tbnik";
            this.tbnik.Size = new System.Drawing.Size(248, 22);
            this.tbnik.TabIndex = 44;
            // 
            // CRUDPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1402, 737);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDPenyewa";
            this.Text = "CRUDPenyewa";
            this.Load += new System.EventHandler(this.CRUDPenyewa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridcrudpenyewa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleKaryawanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCustomDataGrid dgridcrudpenyewa;
        private System.Windows.Forms.TextBox tbIdpenyewa;
        private ns1.BunifuMaterialTextbox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbnama;
        private ns1.BunifuThinButton2 btnupadate;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuThinButton2 btndelete;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuThinButton2 btnSave;
        private System.Windows.Forms.BindingSource tblRoleKaryawanBindingSource;
        private PRG2_KEL10DataSet1 pRG2_KEL10DataSet1;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.Label label5;
        private PRG2_KEL10DataSet1TableAdapters.tblRoleKaryawanTableAdapter tblRoleKaryawanTableAdapter;
        private PRG2_KEL10DataSet pRG2_KEL10DataSet;
        private System.Windows.Forms.TextBox tbnik;
    }
}