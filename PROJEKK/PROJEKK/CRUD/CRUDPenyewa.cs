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

namespace PROJEKK.CRUD
{
    public partial class CRUDPenyewa : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public CRUDPenyewa()
        {
            InitializeComponent();
        }

        public void clear()
        {
            tbIdpenyewa.Enabled = false;
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdPenyewa";
            a.setID("PNY", sp);
            string id = a.getID();
            tbIdpenyewa.Text = id;
            tbnik.Text = "";
            tbnama.Clear();
            tbalamat.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdPenyewa";
            a.setID("PNY", sp);
            string id = a.getID();
            string nama = tbnama.Text;
            string alamat = tbalamat.Text;
            string no = tbNoTelp.Text;
            string nik = tbnik.Text;
            tbIdpenyewa.Text = id;

            try
            {
              
                if (no.Length > 13 || no.Length < 8)
                {
                    MessageBox.Show("Panjang digit no telepon anda tidak memenuhi standar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNoTelp.Text = "";
                }

                else if (nama == "" || no == "" || alamat == "" || nik == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_Insertpenyewa", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("idPenyewa", id);
                    insert.Parameters.AddWithValue("pny_nik", nik);
                    insert.Parameters.AddWithValue("pny_nama", nama);
                    insert.Parameters.AddWithValue("pny_noTelp", no);
                    insert.Parameters.AddWithValue("pny_alamt", alamat);   
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil disimpan dengan ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnupadate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                tbnik.Text = "";
                tbnama.Text = "";
                tbNoTelp.Text = "";
                tbalamat.Text = "";
                // btnupadate.Enabled = false;
                //btndelete.Enabled = false;
                btnSave.Enabled = true;

                con.Open();
                try
                {
                    clear();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_Loadpenyewa", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dgridcrudpenyewa.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dgridcrudpenyewa.Columns[0].HeaderCell.Value = "ID Penyewa";
                dgridcrudpenyewa.Columns[1].HeaderCell.Value = "NIK";
                dgridcrudpenyewa.Columns[2].HeaderCell.Value = "Nama";
                dgridcrudpenyewa.Columns[3].HeaderCell.Value = "No Telp";
                dgridcrudpenyewa.Columns[4].HeaderCell.Value = "Alamat ";
                dgridcrudpenyewa.Columns[1].Width = 300;
                dgridcrudpenyewa.Columns[4].Width = 200;
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void CRUDPenyewa_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
