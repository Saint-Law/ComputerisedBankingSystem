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

namespace ComputerisedBankingSystem
{
    public partial class StaffData : Form
    {
        public StaffData()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7FF550F\MSSQLSERVER01;Initial Catalog=Bank;Integrated Security=True");

        private void StaffData_Load(object sender, EventArgs e)
        {
            GridPatientData();
        }

        public void GridPatientData()
        {
            string cmdText = "SELECT * FROM Staff";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dgvStaff.DataSource = ds.Tables[0];
        }

        public void SearchByName()
        {
            string cmdText = "SELECT * FROM Staff where name='" + txtsName.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dgvStaff.DataSource = ds.Tables[0];
        }

        public void searchByID()
        {
            string cmdText = "SELECT * FROM Staff where staffid='" + txtSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dgvStaff.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchByID();
        }

        private void txtsName_TextChanged(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GridPatientData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
