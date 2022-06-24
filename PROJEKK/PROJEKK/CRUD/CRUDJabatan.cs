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

namespace PROJEKK
{
    public partial class CRUDRoleKaryawan : Form
    {
        String ID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);

        public void clear()
        {
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdRole";
            a.setID("RL", sp);
            string id = a.getID();
            txtIdrole.Text = id;
            txtnama.Clear();
        }
        public CRUDRoleKaryawan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                idOtomatis a = new idOtomatis();
                string sp = "sp_IdRole";
                a.setID("RL", sp);
                string id = a.getID();
                string deskripsi = txtnama.Text;
                if (deskripsi == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertRole", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("idRole", id);
                    insert.Parameters.AddWithValue("nama_role", deskripsi);
                    con.Open();
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
        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                txtnama.Text = "";
               // btnUpdate.Enabled = false;
                //btnDelete.Enabled = false;
                btnSave.Enabled = true;
                try
                {
                    clear();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadRole", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dgridRole.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dgridRole.Columns[0].HeaderCell.Value = "ID Role";
                dgridRole.Columns[1].HeaderCell.Value = "Deskripsi";
                dgridRole.Columns[0].Width = 150;
                dgridRole.Columns[1].Width = 500;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txtIdrole_TextChanged(object sender, EventArgs e)
        {
            txtIdrole.Enabled = false;
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdRole";
            a.setID("RL", sp);
            string id = a.getID();
            id = txtIdrole.Text;

        }

        private void CRUDRoleKaryawan_Load(object sender, EventArgs e)
        {
            LoadData();
            txtIdrole.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
        }

        private void dgridRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string ID = txtIdrole.Text;
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteRole", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("idRole", ID);
                try
                {
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
            }
        }

        private void dgridRole_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dgridRole.Rows[e.RowIndex];
                    //transfer ke textbox
                    txtIdrole.Text = row.Cells[0].Value.ToString();
                    txtnama.Text = row.Cells[1].Value.ToString();   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIdrole.Text;
                string deskripsi = txtnama.Text;
                if (deskripsi == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (id == "RL0001" || id == "RL0002" || id == "RL0003")
                {
                    MessageBox.Show("Jabatan ini tidak boleh diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateRole", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("idRole", id);
                    update.Parameters.AddWithValue("nama_role", deskripsi);
                    try
                    {
                        update.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update: " + ex.Message);
                    }
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dgridRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}
