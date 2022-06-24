﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.Configuration;

namespace PROJEKK.FORM
{
    public partial class FormKasir : Form
    {
        string id;
        private Form currchildform;
        private Panel leftBorderBtn;
        private IconButton currentBtn;

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public FormKasir()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 49);
            PANELCONTROL.Controls.Add(leftBorderBtn);
            WindowState = FormWindowState.Maximized;
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 0, 0);
            public static Color color2 = Color.FromArgb(0, 0, 0);
            public static Color color3 = Color.FromArgb(0, 0, 0);
            public static Color color4 = Color.FromArgb(0, 0, 0);
        }

       

        private void openChildForm(Form childform)
        {
            if (currchildform != null)
            {
                currchildform.Close();
            }
            currchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbljudul.Text = childform.Text;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DissabledButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon title bar
                //iconcurchildform.IconChar = currentBtn.IconChar;
                //lblcurchildform.Text = currentBtn.Text;
            }
        }

        private void DissabledButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(70, 130, 180);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.MidnightBlue;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PANELCONTROL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand view = new SqlCommand("sp_Load", connection);
            view.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(view);
            adapter.Fill(dt);
            label3.Text = dt.Rows[0][0].ToString();
            connection.Close();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            openChildForm(new TRANSAKSI.TRSLaundry());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult d; d = MessageBox.Show("Yakin ingin Keluar?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                new FormLogin().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Batal", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPenyewa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new CRUD.CRUDPenyewa());
        }
    }
}
