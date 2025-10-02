namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            cmbSection = new ComboBox();
            btnInsertUpdate = new Button();
            txtLocalNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtRequestorName = new TextBox();
            txtEmpID = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(128, 22);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cmbSection);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(txtLocalNumber);
            groupBox1.Controls.Add(txtEmailAddress);
            groupBox1.Controls.Add(txtRequestorName);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.PaleVioletRed;
            groupBox1.Location = new Point(0, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(927, 289);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details Manual Insert and Update";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(204, 203);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbSection
            // 
            cmbSection.ForeColor = Color.PaleVioletRed;
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(77, 169);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(254, 28);
            cmbSection.TabIndex = 12;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertUpdate.Location = new Point(77, 203);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(121, 34);
            btnInsertUpdate.TabIndex = 11;
            btnInsertUpdate.Text = "INSERT/UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = true;
            btnInsertUpdate.Click += button2_Click;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.ForeColor = Color.PaleVioletRed;
            txtLocalNumber.Location = new Point(124, 136);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(207, 27);
            txtLocalNumber.TabIndex = 9;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.ForeColor = Color.PaleVioletRed;
            txtEmailAddress.Location = new Point(124, 103);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(333, 27);
            txtEmailAddress.TabIndex = 8;
            // 
            // txtRequestorName
            // 
            txtRequestorName.ForeColor = Color.PaleVioletRed;
            txtRequestorName.Location = new Point(146, 70);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(311, 27);
            txtRequestorName.TabIndex = 7;
            // 
            // txtEmpID
            // 
            txtEmpID.ForeColor = Color.PaleVioletRed;
            txtEmpID.Location = new Point(164, 36);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(206, 27);
            txtEmpID.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(376, 36);
            button1.Name = "button1";
            button1.Size = new Size(81, 27);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 169);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 4;
            label6.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 135);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 3;
            label5.Text = "Local Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 2;
            label4.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 70);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 1;
            label3.Text = "Requestor Name:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 0;
            label2.Text = "Employee Number:";
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 376);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Button btnInsertUpdate;
        private TextBox txtLocalNumber;
        private TextBox txtEmailAddress;
        private TextBox txtRequestorName;
        private TextBox txtEmpID;
        private Button button1;
        private ComboBox cmbSection;
        private Button btnDelete;
    }
}