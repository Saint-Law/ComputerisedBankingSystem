namespace ComputerisedBankingSystem
{
    partial class StaffData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 65);
            this.panel1.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(530, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Staff Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsName);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1194, 77);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search By Staff Name:";
            // 
            // txtsName
            // 
            this.txtsName.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsName.Location = new System.Drawing.Point(678, 25);
            this.txtsName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsName.Name = "txtsName";
            this.txtsName.Size = new System.Drawing.Size(236, 31);
            this.txtsName.TabIndex = 3;
            this.txtsName.TextChanged += new System.EventHandler(this.txtsName_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1062, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search By  ID:";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReload.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.Location = new System.Drawing.Point(926, 18);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 49);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "&Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(174, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 31);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStaff.Location = new System.Drawing.Point(18, 158);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1194, 503);
            this.dgvStaff.TabIndex = 108;
            // 
            // StaffData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffData";
            this.Load += new System.EventHandler(this.StaffData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.DataGridView dgvStaff;
    }
}