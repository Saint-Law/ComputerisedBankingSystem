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

namespace EventManagementSystem
{
    public partial class CustomerData : Form
    {
        public CustomerData()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8S2JD2B;Initial Catalog=event;Integrated Security=True");

        private void btnGdata_Click(object sender, EventArgs e)
        {
            searchByDate();
        }

        public void GridPatientData()
        {
            string cmdText = "SELECT * FROM customer";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];
        }

        public void SearchByName()
        {
            string cmdText = "SELECT * FROM customer where name='" + txtSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];
        }

        public void searchByID()
        {
            string cmdText = "SELECT * FROM customer where patientid='" + txtSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];
        }

        public void searchByDate()
        {
            string cmdText = "SELECT * FROM customer WHERE date='" + dtpFrom.Text + "' AND date='" + dtpTo.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dgvPayment.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridPatientData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchByID();
        }

        private void txtsName_TextChanged(object sender, EventArgs e)
        {
            SearchByName();
        }
    }
}
