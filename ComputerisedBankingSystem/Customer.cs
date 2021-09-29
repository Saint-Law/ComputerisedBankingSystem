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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7FF550F\MSSQLSERVER01;Initial Catalog=Bank;Integrated Security=True");
        SqlCommand command;
        string imgloc;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp) |*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.Title = "Select Criminal Picture";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    imgloc = open.FileName.ToString();
                    pictureBox1.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                string que = "INSERT INTO Customer VALUES('" + txtid.Text + "','" +
                    txtName.Text + "','" +
                    cmbSex.Text + "','" +
                    txtAdd.Text + "','" +
                    txtContact.Text + "','" +
                    txtMail.Text + "','" +
                    dtpDate.Text + "','" +
                    txtage.Text + "','" +
                    txtnation.Text + "','" +
                    txtState.Text + "','" +
                    txtLga.Text + "','" +
                    txtAno.Text + "','" +
                    cmbTid.Text + "','" +
                    txtIdNo.Text + "','" +
                    dtpDissu.Text + "','" +
                    txtKname.Text + "','" +
                    txtKrel.Text + "','" +
                    txtKadd.Text + "','" +
                    txtKcon.Text + "',@IMG)";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(que, con);
                command.Parameters.Add(new SqlParameter("@IMG", img));
                int affectedrow = command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(affectedrow.ToString() + "customer Record Saved Successfully", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            txtAdd.Clear();
            txtage.Clear();
            txtContact.Clear();
            txtIdNo.Clear();
            txtKadd.Clear();
            txtKcon.Clear();
            cmbSex.SelectedIndex = -1;
            cmbTid.SelectedIndex = -1;
            dtpDate.Text = DateTime.Now.ToString();
            dtpDissu.Text = DateTime.Now.ToString();
            txtKname.Clear();
            txtKrel.Clear();
            txtLga.Clear();
            txtMail.Clear();
            txtName.Clear();
            txtnation.Clear();
            txtState.Clear();

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

        public void generateCusID()
        {

            var chars = "123456789012345";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 7)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtid.Text = "CUS" + result;

        }

        public void generateAcctNo()
        {

            var chars = "123456789012345";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 7)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtid.Text = "211" + result;

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            generateCusID();
            generateAcctNo();
        }
    }
}
