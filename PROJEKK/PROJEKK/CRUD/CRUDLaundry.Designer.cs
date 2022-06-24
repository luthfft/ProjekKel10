namespace PROJEKK.CRUD
{
    partial class CRUDLaundry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDLaundry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPakaian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridLaundry = new ns1.BunifuCustomDataGrid();
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbidLaundry = new System.Windows.Forms.TextBox();
            this.btnupadate = new ns1.BunifuThinButton2();
            this.btndelete = new ns1.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new ns1.BunifuThinButton2();
            this.tblFasilitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridLaundry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFasilitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.tbHarga);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPakaian);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgridLaundry);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbidLaundry);
            this.panel1.Controls.Add(this.btnupadate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 655);
            this.panel1.TabIndex = 48;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(190, 196);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(172, 22);
            this.tbHarga.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Harga PER KG";
            // 
            // tbPakaian
            // 
            this.tbPakaian.Location = new System.Drawing.Point(190, 131);
            this.tbPakaian.Margin = new System.Windows.Forms.Padding(4);
            this.tbPakaian.Name = "tbPakaian";
            this.tbPakaian.Size = new System.Drawing.Size(172, 22);
            this.tbPakaian.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id Laundry";
            // 
            // dgridLaundry
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridLaundry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgridLaundry.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgridLaundry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridLaundry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridLaundry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgridLaundry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridLaundry.DoubleBuffered = true;
            this.dgridLaundry.EnableHeadersVisualStyles = false;
            this.dgridLaundry.HeaderBgColor = System.Drawing.Color.Silver;
            this.dgridLaundry.HeaderForeColor = System.Drawing.Color.Black;
            this.dgridLaundry.Location = new System.Drawing.Point(65, 262);
            this.dgridLaundry.Name = "dgridLaundry";
            this.dgridLaundry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridLaundry.RowTemplate.Height = 24;
            this.dgridLaundry.Size = new System.Drawing.Size(739, 283);
            this.dgridLaundry.TabIndex = 46;
            this.dgridLaundry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridLaundry_CellClick);
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
            this.tbSearch.Location = new System.Drawing.Point(608, 211);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(148, 44);
            this.tbSearch.TabIndex = 45;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::PROJEKK.Properties.Resources.icons8_search_30;
            this.btnSearch.Location = new System.Drawing.Point(763, 215);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 42);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbidLaundry
            // 
            this.tbidLaundry.Location = new System.Drawing.Point(190, 59);
            this.tbidLaundry.Margin = new System.Windows.Forms.Padding(4);
            this.tbidLaundry.Name = "tbidLaundry";
            this.tbidLaundry.Size = new System.Drawing.Size(172, 22);
            this.tbidLaundry.TabIndex = 34;
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
            this.btnupadate.Location = new System.Drawing.Point(299, 575);
            this.btnupadate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupadate.Name = "btnupadate";
            this.btnupadate.Size = new System.Drawing.Size(124, 42);
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
            this.btndelete.Location = new System.Drawing.Point(471, 575);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(124, 42);
            this.btndelete.TabIndex = 42;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Pakaian";
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
            this.btnSave.Location = new System.Drawing.Point(135, 575);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 42);
            this.btnSave.TabIndex = 41;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblFasilitasBindingSource
            // 
            this.tblFasilitasBindingSource.DataMember = "tblFasilitas";
            // 
            // CRUDLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1090, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "CRUDLaundry";
            this.Text = "MASTER LAUNDRY";
            this.Load += new System.EventHandler(this.CRUDLaundry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridLaundry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFasilitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCustomDataGrid dgridLaundry;
        private ns1.BunifuMaterialTextbox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbidLaundry;
        private ns1.BunifuThinButton2 btnupadate;
        private ns1.BunifuThinButton2 btndelete;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuThinButton2 btnSave;
        private System.Windows.Forms.BindingSource tblFasilitasBindingSource;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPakaian;
    }
}