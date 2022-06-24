namespace PROJEKK
{
    partial class CRUDKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDKaryawan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbIdkaryawan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.tblRoleKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRG2_KEL10DataSet1 = new PROJEKK.PRG2_KEL10DataSet1();
            this.pRG2_KEL10DataSet = new PROJEKK.PRG2_KEL10DataSet();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnupadate = new ns1.BunifuThinButton2();
            this.btndelete = new ns1.BunifuThinButton2();
            this.btnSave = new ns1.BunifuThinButton2();
            this.tblRoleKaryawanTableAdapter = new PROJEKK.PRG2_KEL10DataSet1TableAdapters.tblRoleKaryawanTableAdapter();
            this.dgridcrudkaryawan = new ns1.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleKaryawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridcrudkaryawan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIdkaryawan
            // 
            this.tbIdkaryawan.Location = new System.Drawing.Point(158, 90);
            this.tbIdkaryawan.Name = "tbIdkaryawan";
            this.tbIdkaryawan.Size = new System.Drawing.Size(163, 22);
            this.tbIdkaryawan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Karyawan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(49, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alamat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(49, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(158, 172);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(248, 22);
            this.tbnama.TabIndex = 4;
            this.tbnama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnama_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(49, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role";
            // 
            // cbrole
            // 
            this.cbrole.DataSource = this.tblRoleKaryawanBindingSource;
            this.cbrole.DisplayMember = "nama_role";
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Location = new System.Drawing.Point(158, 130);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(163, 24);
            this.cbrole.TabIndex = 8;
            this.cbrole.ValueMember = "idRole";
            // 
            // tblRoleKaryawanBindingSource
            // 
            this.tblRoleKaryawanBindingSource.DataMember = "tblRoleKaryawan";
            this.tblRoleKaryawanBindingSource.DataSource = this.pRG2_KEL10DataSet1;
            // 
            // pRG2_KEL10DataSet1
            // 
            this.pRG2_KEL10DataSet1.DataSetName = "PRG2_KEL10DataSet1";
            this.pRG2_KEL10DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRG2_KEL10DataSet
            // 
            this.pRG2_KEL10DataSet.DataSetName = "PRG2_KEL10DataSet";
            this.pRG2_KEL10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(158, 215);
            this.tbalamat.Multiline = true;
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(248, 92);
            this.tbalamat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(49, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "No Telepon";
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Location = new System.Drawing.Point(158, 326);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(163, 22);
            this.tbNoTelp.TabIndex = 10;
            this.tbNoTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoTelp_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(49, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(158, 379);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(248, 22);
            this.tbusername.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(49, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(158, 419);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(248, 22);
            this.tbpass.TabIndex = 14;
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
            this.tbSearch.Location = new System.Drawing.Point(1062, 39);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(163, 44);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1217, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 42);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnupadate.Location = new System.Drawing.Point(204, 535);
            this.btnupadate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupadate.Name = "btnupadate";
            this.btnupadate.Size = new System.Drawing.Size(139, 42);
            this.btnupadate.TabIndex = 19;
            this.btnupadate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupadate.Click += new System.EventHandler(this.btnupadate_Click);
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
            this.btndelete.Location = new System.Drawing.Point(368, 535);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 42);
            this.btndelete.TabIndex = 18;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.btnSave.Location = new System.Drawing.Point(43, 535);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 17;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblRoleKaryawanTableAdapter
            // 
            this.tblRoleKaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // dgridcrudkaryawan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridcrudkaryawan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridcrudkaryawan.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgridcrudkaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridcrudkaryawan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridcrudkaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridcrudkaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridcrudkaryawan.DoubleBuffered = true;
            this.dgridcrudkaryawan.EnableHeadersVisualStyles = false;
            this.dgridcrudkaryawan.HeaderBgColor = System.Drawing.Color.Silver;
            this.dgridcrudkaryawan.HeaderForeColor = System.Drawing.Color.Black;
            this.dgridcrudkaryawan.Location = new System.Drawing.Point(440, 91);
            this.dgridcrudkaryawan.Name = "dgridcrudkaryawan";
            this.dgridcrudkaryawan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridcrudkaryawan.RowTemplate.Height = 24;
            this.dgridcrudkaryawan.Size = new System.Drawing.Size(969, 426);
            this.dgridcrudkaryawan.TabIndex = 23;
            this.dgridcrudkaryawan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridcrudkaryawan_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgridcrudkaryawan);
            this.panel1.Controls.Add(this.tbIdkaryawan);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbnama);
            this.panel1.Controls.Add(this.btnupadate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbrole);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbalamat);
            this.panel1.Controls.Add(this.tbpass);
            this.panel1.Controls.Add(this.tbNoTelp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbusername);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 645);
            this.panel1.TabIndex = 24;
            // 
            // CRUDKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1422, 649);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDKaryawan";
            this.Text = "MASTER KARYAWAN";
            this.Load += new System.EventHandler(this.CRUDKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleKaryawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRG2_KEL10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridcrudkaryawan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdkaryawan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbpass;
        private ns1.BunifuThinButton2 btnSave;
        private ns1.BunifuThinButton2 btndelete;
        private ns1.BunifuThinButton2 btnupadate;
        private System.Windows.Forms.Button btnSearch;
        private ns1.BunifuMaterialTextbox tbSearch;
        private PRG2_KEL10DataSet pRG2_KEL10DataSet;
        private PRG2_KEL10DataSet1 pRG2_KEL10DataSet1;
        private System.Windows.Forms.BindingSource tblRoleKaryawanBindingSource;
        private PRG2_KEL10DataSet1TableAdapters.tblRoleKaryawanTableAdapter tblRoleKaryawanTableAdapter;
        private ns1.BunifuCustomDataGrid dgridcrudkaryawan;
        private System.Windows.Forms.Panel panel1;
    }
}