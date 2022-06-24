using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PROJEKK
{
    public partial class CRUDTipeKamar : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public CRUDTipeKamar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void clear()
        {
            txtidKamar.Enabled = false;
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdTipeKamar";
            a.setID("KM", sp);
            string id = a.getID();
            txtdesc.Text = "";
            txtHarga.Text = "";
            txtLuas.Text = "";
            txtidKamar.Text = id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdTipeKamar";
            a.setID("KM", sp);
            string id = a.getID();
            string desc = txtdesc.Text;
            string luas = txtLuas.Text;
            string harga = txtHarga.Text;
            txtidKamar.Text = id;

            try
            {
                con.Open();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand insert = new SqlCommand("sp_InsertTipeKamar", con);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("idKamar", id);
                insert.Parameters.AddWithValue("tk_desc", desc);
                insert.Parameters.AddWithValue("tk_luas", luas);
                insert.Parameters.AddWithValue("tk_harga", harga);
                insert.Parameters.AddWithValue("tk_status",cmbStatus.SelectedIndex);
                insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan dengan ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
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
                cmbStatus.Text = "";
                txtdesc.Text = "";
                txtHarga.Text = "";
                txtLuas.Text = "";
                // btnupadate.Enabled = false;
                //btndelete.Enabled = false;
                btnSave.Enabled = true;

                con.Open();
                try
                {
                    clear();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadTipeKamar", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dgridKamar.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
               // dgridKamar.Columns[0].HeaderCell.Value = "ID Kamar";
                dgridKamar.Columns[1].HeaderCell.Value = "Deskripsi";
                dgridKamar.Columns[2].HeaderCell.Value = "Luas";
                dgridKamar.Columns[3].HeaderCell.Value = "Harga";
                dgridKamar.Columns[4].HeaderCell.Value = "Status";
                dgridKamar.Columns[4].Width = 250;
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnupadate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtidKamar.Text;
                string deskripsi = txtdesc.Text;
                string desc = txtdesc.Text;
                string luas = txtLuas.Text;
                string harga = txtHarga.Text;

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
                    SqlCommand update = new SqlCommand("sp_Updatetipekamar", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("idKamar", id);
                    update.Parameters.AddWithValue("tk_desc", deskripsi);
                    update.Parameters.AddWithValue("tk_luas", luas);
                    update.Parameters.AddWithValue("tk_harga", harga);
                    update.Parameters.AddWithValue("tk_status", cmbStatus.SelectedIndex);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            string ID = txtidKamar.Text;
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteTipeKamar", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("idKamar", ID);
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

        private void CRUDTipeKamar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgridKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dgridKamar.Rows[e.RowIndex];
                    //transfer ke textbox
                    txtidKamar.Text = row.Cells[0].Value.ToString();
                    txtdesc.Text = row.Cells[1].Value.ToString();
                    txtLuas.Text = row.Cells[2].Value.ToString();
                    float Harga = float.Parse(row.Cells[3].Value.ToString());
                    txtHarga.Text = Harga.ToString();
                    cmbStatus.Text = row.Cells[4].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                clear();
            }
        }
    }
}
