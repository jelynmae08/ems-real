namespace EmployeeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSideMenu = new Panel();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            btnClose = new Button();
            pnlTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            pnlStage = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.PaleVioletRed;
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 54);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(220, 443);
            pnlSideMenu.TabIndex = 0;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Dock = DockStyle.Top;
            btnAddEmp.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmp.ForeColor = Color.PaleVioletRed;
            btnAddEmp.Location = new Point(0, 52);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(220, 51);
            btnAddEmp.TabIndex = 1;
            btnAddEmp.Text = "ADD EMPLOYEE";
            btnAddEmp.UseVisualStyleBackColor = true;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.Dock = DockStyle.Top;
            btnMasterData.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterData.ForeColor = Color.PaleVioletRed;
            btnMasterData.Location = new Point(0, 0);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(220, 52);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = "MASTER DATA";
            btnMasterData.UseVisualStyleBackColor = true;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(785, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Х";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.PaleVioletRed;
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(828, 54);
            pnlTitleBar.TabIndex = 0;
            pnlTitleBar.Paint += pnlTitleBar_Paint;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(709, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(31, 23);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "━";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += button3_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Location = new Point(746, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(33, 23);
            btnMaximize.TabIndex = 0;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // pnlStage
            // 
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.Location = new Point(220, 54);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(608, 443);
            pnlStage.TabIndex = 2;
            pnlStage.Paint += pnlStage_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 497);
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Button btnClose;
        private Panel pnlTitleBar;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnAddEmp;
        private Button btnMasterData;
        private Panel pnlStage;
    }
}
