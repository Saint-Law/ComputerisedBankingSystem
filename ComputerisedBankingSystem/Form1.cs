using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EventManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashscreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (txtUname.Text == "admin" && txtPwd.Text == "admin")
            {
                MessageBox.Show("UBA BANKING SYSTEM", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
        }

        public void splashscreen()
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
