using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

using System.Runtime.InteropServices;

namespace PROJEKK
{
    public partial class FormLogin : Form
    {
        string id;
        string jabatan;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        private Form currchildform;
        public FormLogin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPass_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        public void clear()
        {
            tbUsername.Text = "Username";
            tbPass.Text = "Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_PwUname", connection);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("username", tbUsername.Text);
                view.Parameters.AddWithValue("password", tbPass.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);   
                connection.Close();
                if (st.Rows.Count != 0)
                {
                    if (st.Rows[0][1].ToString() == "0")
                    {
                        MessageBox.Show("Username/Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        id = st.Rows[0][0].ToString();
                        jabatan = st.Rows[0][1].ToString();
                        if (jabatan == "RL0001")
                        {
                            login();
                            MessageBox.Show("Selamat datang Bapak/Ibu Kasir!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new FORM.FormKasir().Show();
                            this.Hide();
                        }
                        else if (jabatan == "RL0002")
                        {
                            login();
                            MessageBox.Show("Selamat datang Bapak/Ibu Manager!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // openChildForm(new FormManager());
                        }
                        else if (jabatan == "RL0003")
                        {
                            login();
                            MessageBox.Show("Selamat datang Bapak/Ibu Admin!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new FormAdmin().Show();
                            this.Hide();
                        }
                        else if (jabatan == "RL0004")
                        {
                            login();
                            MessageBox.Show("Selamat datang Bapak/Ibu Laundry!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new FormAdmin().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Anda tidak memiliki hak akses login!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Username/password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void login()
        {
            connection.Open();
            SqlCommand login = new SqlCommand("sp_Login", connection);
            login.CommandType = CommandType.StoredProcedure;
            login.Parameters.AddWithValue("@idKaryawan", id);
            try
            {
                login.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save pegawai login: " + ex.Message);
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbPass_OnValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void tbUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                tbPass.isPassword = false;
            }
            else
            {
                tbPass.isPassword = true;
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            tbPass.isPassword = true;
        }
    }
}
