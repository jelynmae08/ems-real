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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public static string selectedTransaction;
        public static string RequestorName;
        public static string EmailAddress;
        public static string Section;
        public static string localNumber;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "Select * from [tblemployeeData] where [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
            if (txtEmpID.Text == "" || txtEmailAddress.Text == "" || txtRequestorName.Text == "" || cmbSection.Text == "" || txtLocalNumber.Text == "")
            {
                MessageBox.Show("Incomplete/MissingData", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dtg_addrequestor == true)
            {
                MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
            }
            else
            {
                string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName],[RequestorEmail],[Section],[LocalNumber]) values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = frmMasterData.selectedTransaction;
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.EmailAddress;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.localNumber;
        }
    }
}
