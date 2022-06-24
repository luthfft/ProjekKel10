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

namespace PROJEKK.TRANSAKSI
{
    public partial class TRSLaundry : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        public TRSLaundry()
        {
            InitializeComponent();
        }

        private void dgridLaundry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TRSLaundry_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void clear()
        {
            tbIdtrs.Enabled = false;
            idOtomatis a = new idOtomatis();
            string sp = "sp_IdtTRSLaundry";
            a.setID("TRL", sp);
            string id = a.getID();
            tbidLaundry.Text = "";
            tbPakaian.Text = "";
            tbHarga.Text = "";
            tbIdtrs.Text = id;
        }

        void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                // btnUpdate.Enabled = false;
                //btnDelete.Enabled = false;
                try
                {
                    clear();
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadLaundry", con);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dgridLoadLaundry.DataSource = bindingSource1;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dgridLoadLaundry.Columns[0].HeaderCell.Value = "ID Laundry";
                dgridLoadLaundry.Columns[1].HeaderCell.Value = "Pakaian";
                dgridLoadLaundry.Columns[2].HeaderCell.Value = "Harga";
                dgridLoadLaundry.Columns[0].Width = 150;
                dgridLoadLaundry.Columns[1].Width = 250;
                dgridLoadLaundry.Columns[2].Width = 200;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dgridLoadLaundry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgridLoadLaundry_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgridLoadLaundry_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dgridLoadLaundry.Rows[e.RowIndex];
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

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int Total = int.Parse(tbHarga.Text) * int.Parse(tbBerat.Text);
            tbHarTot.Text = Total.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
