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
using System.IO;

namespace EventManagementSystem
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8S2JD2B;Initial Catalog=event;Integrated Security=True");
        SqlCommand command;

        private void btnUpdte_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" && txtKphone.Text == "")
            {
                MessageBox.Show("NO field should be left empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            string que = "UPDATE customer SET name='" +
                   txtName.Text + "',gender='" +
                   cmbSex.Text + "',dob='" +
                   dtpDate.Text + "',address='" +
                   txtAdd.Text + "',contact='" +
                   txtPhone.Text + "',email='" +
                   txtMail.Text + "',kinname='" +
                   txtKin.Text + "',kinphone'" +
                   txtKphone.Text + "' WHERE patientid='" + txtid.Text + "'";
            SqlCommand command = new SqlCommand(que, con);
            int affectedrow = command.ExecuteNonQuery();
            if (affectedrow > 0)
            {
                MessageBox.Show("customer Record Updated Successfully", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is a problem", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            txtName.Clear();
            txtAdd.Clear();
            txtPhone.Clear();
            pictureBox1.Image = null;
            txtMail.Clear();
            txtid.Focus();
            txtid.Clear();
            dtpDate.Text = DateTime.Now.ToString();
            cmbSex.SelectedIndex = -1;
            txtKin.Clear();
            txtKphone.Clear();
        }

        public void getCustomertRecord()
        {
            try
            {
                string quarry = "SELECT * FROM customer where patientid='" + txtid.Text + "'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(quarry, con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    txtName.Text = reader[1].ToString();
                    cmbSex.Text = reader[2].ToString();
                    dtpDate.Text = reader[3].ToString();
                    txtAdd.Text = reader[4].ToString();
                    txtPhone.Text = reader[5].ToString();
                    txtMail.Text = reader[6].ToString();
                    txtKin.Text = reader[7].ToString();
                    txtKphone.Text = reader[8].ToString();
                    byte[] img = (byte[])(reader[9]);
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("this does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            getCustomertRecord();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" && txtKphone.Text == "")
            {
                MessageBox.Show("NO field should be left empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            string que = "DELETE FROM customer WHERE patientid='" + txtid.Text + "'";
            SqlCommand command = new SqlCommand(que, con);
            int affectedrow = command.ExecuteNonQuery();
            if (affectedrow > 0)
            {
                MessageBox.Show("customer Record Deleted Successfully", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is a problem", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            txtName.Clear();
            txtAdd.Clear();
            txtPhone.Clear();
            pictureBox1.Image = null;
            txtMail.Clear();
            txtid.Focus();
            txtid.Clear();
            dtpDate.Text = DateTime.Now.ToString();
            cmbSex.SelectedIndex = -1;
            txtKin.Clear();
            txtKphone.Clear();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            CustomerData data = new CustomerData();
            data.ShowDialog();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
