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
    public partial class BvnGen : Form
    {
        public BvnGen()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7FF550F\MSSQLSERVER01;Initial Catalog=Bank;Integrated Security=True");

        private void BvnGen_Load(object sender, EventArgs e)
        {
            //validate();
        }

        //public void validate()
        //{
        //    if (String.IsNullOrEmpty(txtCacct.Text))
        //    {
        //        btnGenerate.Visible = false;
        //    }

        //    if (!String.IsNullOrEmpty(txtCacct.Text))
        //    {
        //        btnGenerate.Visible = true; 
        //    }       
        //}

        public void getBVN()
        {

            var chars = "12345678900987654321";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 10)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtbvn.Text = result;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getBVN();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbvn.Text == "" && txtCacct.Text == "")
            {
                MessageBox.Show("No field should be left empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            string query = "INSERT INTO expense VALUES('" + txtCacct.Text + "','" +
                txtfName.Text + "','" +
                txtLname.Text + "','" +
                txtbvn.Text + "')";
            SqlCommand command = new SqlCommand(query, con);
            int affectedrow = command.ExecuteNonQuery();
            if (affectedrow > 0)
            {
                MessageBox.Show("Data Saved Successfully...!!!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is a problem", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.Close();
            
        }
    }
}
