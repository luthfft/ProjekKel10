using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJEKK
{
    public partial class CRUDKaryawan : Form
    {
        string ID, username;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public CRUDKaryawan()
        {
            
            InitializeComponent();

        }
        public void clear()
        {
            tbIdkaryawan.Enabled = false;
            idOtomatis a = new idOtomatis();
            string sp = "sp_Idkar";
            a.setID("KR", sp);
            string id = a.getID();
            tbIdkaryawan.Text = id;
            cbrole.Text = "";
            tbnama.Clear();
            tbalamat.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idOtomatis a = new idOtomatis();
            string sp = "sp_Idkar";
            a.setID("KR", sp);
            string id = a.getID();
            string nama = tbnama.Text;
            string alamat = tbalamat.Text;
            string no = tbNoTelp.Text;
            string username = tbusername.Text;
            string password = tbpass.Text;
            tbIdkaryawan.Text = id;

            try
            {
                con.Open();
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_CariUsername", con);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("username", tbusername.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                if (st.Rows.Count != 0)
                {
                    MessageBox.Show("Username tersebut sudah tidak tersedia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                else if (no.Length > 13 || no.Length < 8)
                {
                    MessageBox.Show("Panjang digit no telepon anda tidak memenuhi standar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNoTelp.Text = "";
                }
             
                else if (nama == "" || no == "" || alamat == "" || cbrole.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_Insertkaryawan", con);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("idKaryawan", id);
                    insert.Parameters.AddWithValue("idRole", cbrole.SelectedValue);
                    insert.Parameters.AddWithValue("kr_nama", nama);
                    insert.Parameters.AddWithValue("kr_alamat", alamat);
                    insert.Parameters.AddWithValue("kr_notelp", no);
                    insert.Parameters.AddWithValue("username", username);
                    insert.Parameters.AddWithValue("password", password);
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
                cbrole.Text = "";
                tbnama.Text = "";
                tbNoTelp.Text = "";
                tbusername.Text = "";
                tbpass.Text = "";
               // btnupadate.Enabled = false;
                //btndelete.Enabled = false;
                btnSave.Enabled = true;
              
                con.Open();
                try
                {
                    clear();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_Loadkar", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dgridcrudkaryawan.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dgridcrudkaryawan.Columns[0].HeaderCell.Value = "ID Karyawan";
                dgridcrudkaryawan.Columns[1].HeaderCell.Value = "Role";
                dgridcrudkaryawan.Columns[2].HeaderCell.Value = "Nama";
                dgridcrudkaryawan.Columns[3].HeaderCell.Value = "Alamat";
                dgridcrudkaryawan.Columns[4].HeaderCell.Value = "No Telepon";
                dgridcrudkaryawan.Columns[5].HeaderCell.Value = "Username";
                dgridcrudkaryawan.Columns[6].HeaderCell.Value = "Password";
                dgridcrudkaryawan.Columns[1].Width = 300;
                dgridcrudkaryawan.Columns[4].Width = 200;
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void CRUDKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRG2_KEL10DataSet1.tblRoleKaryawan' table. You can move, or remove it, as needed.
            this.tblRoleKaryawanTableAdapter.Fill(this.pRG2_KEL10DataSet1.tblRoleKaryawan);
            // TODO: This line of code loads data into the 'pRG2_KEL10DataSet.tblRoleKaryawan' table. You can move, or remove it, as needed.
            //this.tblRoleKaryawanTableAdapter.Fill(this.pRG2_KEL10DataSet.tblRoleKaryawan);
            LoadData();
            this.CenterToScreen();


         
        }

        private void btnupadate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbIdkaryawan.Text;
                string idRole = cbrole.Text;
                string nama = tbnama.Text;
                string alamat = tbalamat.Text;
                string no = tbNoTelp.Text;
                string username = tbusername.Text;
                string password1 = tbpass.Text;
                if (no.Length > 13 || no.Length < 8)
                {
                    MessageBox.Show("Panjang digit no telepon anda tidak memenuhi standar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNoTelp.Text = "";
                }
              
                else if (nama == "" || no == "" || alamat == "" || username == "" || password1 == "" )
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!username.Equals(tbusername.Text))
                {
                    con.Open();
                    DataTable st = new DataTable(); 
                    SqlCommand view = new SqlCommand("sp_CariUsername", con);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("username", tbusername.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    if (st.Rows.Count != 0)
                    {
                        MessageBox.Show("Username tersebut sudah tidak tersedia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        edit();
                    }
                }
                else
                {
                    edit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void edit()
        {
            string id = tbIdkaryawan.Text; ;
            string idRole = cbrole.SelectedValue.ToString();
            string nama = tbnama.Text;
            string alamat = tbalamat.Text;
            string no = tbNoTelp.Text;
            string username = tbusername.Text;
            string password = tbpass.Text;

            SqlCommand update = new SqlCommand("sp_UpdateKaryawan", con);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("idRole", idRole);
            update.Parameters.AddWithValue("kr_nama", nama);
            update.Parameters.AddWithValue("kr_alamat", alamat);
            update.Parameters.AddWithValue("kr_notelp", no);
            update.Parameters.AddWithValue("username", username);
            update.Parameters.AddWithValue("password", password);
            update.Parameters.AddWithValue("idKaryawan", id);
            try
            {
                con.Open();
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

        private void dgridcrudkaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dgridcrudkaryawan.Rows[e.RowIndex];
                    //transfer ke textbox
                    tbIdkaryawan.Text = row.Cells[0].Value.ToString();
                    cbrole.Text = row.Cells[1].Value.ToString();
                    tbnama.Text = row.Cells[2].Value.ToString();
                    tbalamat.Text = row.Cells[3].Value.ToString();
                    tbNoTelp.Text = row.Cells[4].Value.ToString();
                    tbusername.Text = row.Cells[5].Value.ToString();
                    tbpass.Text = row.Cells[6].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                clear();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string id = tbIdkaryawan.Text;
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                con.Open();
                SqlCommand update = new SqlCommand("sp_DeleteKaryawan", con);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("idKaryawan", id);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbSearch.Text == "")
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
                        SqlCommand view = new SqlCommand("sp_CariKaryawan", con);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("idKaryawan", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        dgridcrudkaryawan.DataSource = bindingSource1;
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    dgridcrudkaryawan.Columns[0].HeaderCell.Value = "ID Karyawan";
                    dgridcrudkaryawan.Columns[1].HeaderCell.Value = "Role";
                    dgridcrudkaryawan.Columns[2].HeaderCell.Value = "Nama";
                    dgridcrudkaryawan.Columns[3].HeaderCell.Value = "Alamat";
                    dgridcrudkaryawan.Columns[4].HeaderCell.Value = "No Telepon";
                    dgridcrudkaryawan.Columns[5].HeaderCell.Value = "Username";
                    dgridcrudkaryawan.Columns[6].HeaderCell.Value = "Password";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

        }

        private void tbNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                            SqlCommand view = new SqlCommand("sp_CariKaryawan", con);
                            view.CommandType = CommandType.StoredProcedure;
                            view.Parameters.AddWithValue("cari", cari);
                            SqlDataAdapter adapter = new SqlDataAdapter(view);
                            adapter.Fill(st);
                            bindingSource1.DataSource = st;
                            dgridcrudkaryawan.DataSource = bindingSource1;
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                        dgridcrudkaryawan.Columns[0].HeaderCell.Value = "ID Karyawan";
                        dgridcrudkaryawan.Columns[1].HeaderCell.Value = "Role";
                        dgridcrudkaryawan.Columns[2].HeaderCell.Value = "Nama";
                        dgridcrudkaryawan.Columns[3].HeaderCell.Value = "Alamat";
                        dgridcrudkaryawan.Columns[4].HeaderCell.Value = "No Telepon";
                        dgridcrudkaryawan.Columns[5].HeaderCell.Value = "Username";
                        dgridcrudkaryawan.Columns[6].HeaderCell.Value = "Password";
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
           }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
