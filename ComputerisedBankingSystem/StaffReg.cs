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
    public partial class StaffReg : Form
    {
        public StaffReg()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7FF550F\MSSQLSERVER01;Initial Catalog=Bank;Integrated Security=True");
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" && cmbQualify.Text == "")
            {
                MessageBox.Show("No Field should be left empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            string query = "INSERT INTO Staff VALUES('" + txtPId.Text + "','" +
                txtFname.Text + "','" +
                cmbSex.SelectedItem + "','" +
                txtAdd.Text + "','" +
                txtPhone.Text + "','" +
                txtMail.Text + "','" +
                cmbQualify.SelectedItem + "','" +
                dtpDob.Text + "','" +
                cmbBgroup.SelectedItem + "')";
            SqlCommand command = new SqlCommand(query, con);
            int affectedrow = command.ExecuteNonQuery();
            if (affectedrow > 0)
            {
                MessageBox.Show("Staff Records Saved Successfully...!!!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is a problem", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            txtAdd.Clear();
            txtFname.Clear();
            txtMail.Clear();
            txtPhone.Clear();
            generateStaffID();
            cmbQualify.SelectedIndex = -1;
            cmbBgroup.SelectedIndex = -1;
            cmbSex.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void generateStaffID()
        {
            var chars = "1234567890";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtPId.Text = "UBA" + result;
        }

        private void StaffReg_Load(object sender, EventArgs e)
        {
            generateStaffID();
        }
    }
}
