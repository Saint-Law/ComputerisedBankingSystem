using ComputerisedBankingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        
        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to quit", "closed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffReg reg = new StaffReg();
            reg.ShowDialog();
        }

        private void allStaffDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffData data = new StaffData();
            data.ShowDialog();
        }

        private void editDoctorRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStaff staff = new EditStaff();
            staff.ShowDialog();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserReg reg = new UserReg();
            reg.ShowDialog();
        }

        private void expenseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses exp = new Expenses();
            exp.ShowDialog();
        }

        private void expenseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpensesType type = new ExpensesType();
            type.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.ShowDialog(); 
        }
    }
}
