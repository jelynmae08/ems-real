using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            panel1 = new Panel();
            btnEditData = new Button();
            lblTransactionNumber = new Label();
            pnlChildTitle.SuspendLayout();
            ((ISupportInitialize)dtgMasterData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = SystemColors.ButtonFace;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 39);
            pnlChildTitle.TabIndex = 0;
            pnlChildTitle.Paint += pnlChildTitle_Paint;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.ForeColor = Color.PaleVioletRed;
            lblMasterData.Location = new Point(12, 9);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(114, 22);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "Master Data";
            lblMasterData.Click += lblMasterData_Click;
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = Color.PaleVioletRed;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.Location = new Point(0, 39);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.Size = new Size(748, 334);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellContentClick += dtgMasterData_CellContentClick;
            dtgMasterData.RowHeaderMouseClick += dtgMasterData_RowHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditData);
            panel1.Controls.Add(lblTransactionNumber);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 310);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 50);
            panel1.Size = new Size(748, 63);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditData.BackColor = SystemColors.ButtonFace;
            btnEditData.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditData.ForeColor = Color.PaleVioletRed;
            btnEditData.Location = new Point(661, 19);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(75, 27);
            btnEditData.TabIndex = 3;
            btnEditData.Text = "EDIT DATA";
            btnEditData.UseVisualStyleBackColor = false;
            btnEditData.Click += btnEditData_Click;
            // 
            // lblTransactionNumber
            // 
            lblTransactionNumber.AutoSize = true;
            lblTransactionNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionNumber.ForeColor = Color.PaleVioletRed;
            lblTransactionNumber.Location = new Point(12, 24);
            lblTransactionNumber.Name = "lblTransactionNumber";
            lblTransactionNumber.Size = new Size(175, 17);
            lblTransactionNumber.TabIndex = 2;
            lblTransactionNumber.Text = "<TRANSACTION NUMBER>";
            lblTransactionNumber.Click += lblTransactionNumber1_Click;
            // 
            // frmMasterData
            // 
            ClientSize = new Size(748, 373);
            Controls.Add(panel1);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            Name = "frmMasterData";
            Load += frmMasterData_Load;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((ISupportInitialize)dtgMasterData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlChildTitle;
        private Label lblMasterData;
        private Panel panel1;
        private Label lblTransactionNumber;
        private DataGridView dtgMasterData;

        public static string TransactionNumber;
        public static string selectedTransaction;
        public static string RequestorName;
        public static string EmailAddress;
        public static string Section;
        public Button btnEditData;
        public static string localNumber;
        public DialogResult result;
        public static frmAddEmployee OpenFrmAddEmployee;
        public static string EmployeeID;

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from tblEmployeedata ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }

        private void lblTransactionNumber1_Click(object sender, EventArgs e)
        {
            TransactionNumber = lblTransactionNumber.Text;
        }


        private void txtEditData_TextChanged(object sender, EventArgs e)
        {


        }

        private void pnlChildTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTransactionNumber.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNumber.Text;
            RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            EmailAddress = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            Section = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            localNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
            EmployeeID = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMasterData_Click(object sender, EventArgs e)
        {

        }

        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblTransactionNumber.Text = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            TransactionNumber = lblTransactionNumber.Text;
            frmAddEmployee OpenfrmAddEmployee = new frmAddEmployee();
            OpenfrmAddEmployee.ShowDialog();
        }
    }
}
