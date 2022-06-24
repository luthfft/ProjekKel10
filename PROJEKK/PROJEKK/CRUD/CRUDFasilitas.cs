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
    public partial class CRUDFasilitas : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public CRUDFasilitas()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                idOtomatis a = new idOtomatis();
                string sp = "sp_IdFasilitas";   
                a.setID("FS", sp);
                string id = a.getID();
                string deskripsi = tbDeskripsi.Text;
                string harga = tbHarga.Text;
                if (deskripsi == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertFasilitas", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("idFasilitas", id);
                    insert.Parameters.AddWithValue("fs_desc", deskripsi);
                    insert.Parameters.AddWithValue("fs_harga", harga);
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
                tbDeskripsi.Text = "";
                // btnUpdate.Enabled = false;
                //btnDelete.Enabled = false;
                btnSave.Enabled = true;
                try
                {
                    clear();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadFasilitas", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dgridFasil.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dgridFasil.Columns[0].HeaderCell.Value = "ID Fasilitas";
                dgridFasil.Columns[1].HeaderCell.Value = "Deskripsi";
                dgridFasil.Columns[2].HeaderCell.Value = "Harga";
                dgridFasil.Columns[0].Width = 150;
                dgridFasil.Columns[1].Width = 300;
                dgridFasil.Columns[2].Width = 150;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        public void clear()
        {
            tbidFasilitas.Enabled =false;
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdFasilitas";
            a.setID("FS", sp);
            string id = a.getID();
            tbidFasilitas.Text = id;
            tbDeskripsi.Clear();
            tbHarga.Clear();
        }

        private void tbidFasilitas_TextChanged(object sender, EventArgs e)
        {
        }

        private void CRUDFasilitas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string ID = tbidFasilitas.Text;
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteFasilitas", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("idFasilitas", ID);

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

        private void btnupadate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbidFasilitas.Text;
                string deskripsi = tbDeskripsi.Text;
                string harga = tbHarga.Text;
                if (deskripsi == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateFasilitas", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("idFasilitas", id);
                    update.Parameters.AddWithValue("fs_desc", deskripsi);
                    update.Parameters.AddWithValue("fs_harga", harga);
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

        private void dgridFasil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dgridFasil.Rows[e.RowIndex];
                    //transfer ke textbox
                    tbidFasilitas.Text = row.Cells[0].Value.ToString();
                    tbDeskripsi.Text = row.Cells[1].Value.ToString();
                    float harga = float.Parse(row.Cells[2].Value.ToString());
                    tbHarga.Text = harga.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Data Tidak Ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                LoadData();
                BindingSource bindingSource1 = new BindingSource();
                try
                {
                    string cari = tbSearch.Text;
                    try
                    {
                        con.Open();
                        DataTable st = new DataTable();
                        SqlCommand view = new SqlCommand("sp_CariFasilitas", con);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("idFasilitas", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        dgridFasil.DataSource = bindingSource1;
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    dgridFasil.Columns[0].HeaderCell.Value = "ID Fasilitas";
                    dgridFasil.Columns[1].HeaderCell.Value = "Deskripsi";
                    dgridFasil.Columns[2].HeaderCell.Value = "Harga";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }
    }
}
