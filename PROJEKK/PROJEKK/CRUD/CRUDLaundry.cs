using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJEKK.CRUD
{
    
    public partial class CRUDLaundry : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public CRUDLaundry()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clear()
        {
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdLaundry";
            a.setID("LD", sp);
            string id = a.getID();
            tbPakaian.Text = "";
            tbHarga.Text = "";
            tbidLaundry.Text = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                idOtomatis a = new idOtomatis();
                string sp = "sp_IdLaundry";
                a.setID("LD", sp);
                string id = a.getID();
                string pakaian = tbPakaian.Text;
                string harga = tbHarga.Text;
                if (tbPakaian.Text == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insert = new SqlCommand("sp_InsertLaundry", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("idLaundry", id);
                    insert.Parameters.AddWithValue("dry_pakaian", pakaian);
                    insert.Parameters.AddWithValue("dry_harga", harga);
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
                // btnUpdate.Enabled = false;
                //btnDelete.Enabled = false;
                btnSave.Enabled = true;
                try
                {
                    clear();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadLaundry", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dgridLaundry.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dgridLaundry.Columns[0].HeaderCell.Value = "ID Laundry";
                dgridLaundry.Columns[1].HeaderCell.Value = "Pakaian";
                dgridLaundry.Columns[2].HeaderCell.Value = "Harga";
                dgridLaundry.Columns[0].Width = 150;
                dgridLaundry.Columns[1].Width = 250;
                dgridLaundry.Columns[2].Width = 200;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            
        }

        private void CRUDLaundry_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnupadate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbidLaundry.Text;
                string deskripsi = tbPakaian.Text;
                string harga = tbHarga.Text;
                if (deskripsi == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateLaundry", con);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("idLaundry", id);
                    update.Parameters.AddWithValue("dry_pakaian", deskripsi);
                    update.Parameters.AddWithValue("dry_harga", harga);
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
            string ID = tbidLaundry.Text;
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteLaundry", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("idLaundry", ID);

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

        private void dgridLaundry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dgridLaundry.Rows[e.RowIndex];
                    //transfer ke textbox
                    tbidLaundry.Text = row.Cells[0].Value.ToString();
                    tbPakaian.Text = row.Cells[1].Value.ToString();
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
    }
}

