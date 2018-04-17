namespace RentMe.Views
{
    partial class MDIView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.ToolStripMenuItem();
            this.adminReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnitureReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.maintenanceToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.login,
            this.adminReportsToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuExit});
            this.tsFile.Font = new System.Drawing.Font("Calibri", 12F);
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(44, 23);
            this.tsFile.Text = "&File";
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(122, 24);
            this.menuLogout.Text = "&Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(122, 24);
            this.menuExit.Text = "&Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.furnitureToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Enabled = false;
            this.maintenanceToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.maintenanceToolStripMenuItem.Text = "&Maintenance";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.customerToolStripMenuItem.Text = "Add/Update &Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // furnitureToolStripMenuItem
            // 
            this.furnitureToolStripMenuItem.Name = "furnitureToolStripMenuItem";
            this.furnitureToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.furnitureToolStripMenuItem.Text = "Add/Update &Furniture";
            this.furnitureToolStripMenuItem.Click += new System.EventHandler(this.furnitureToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.addUpdateEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Enabled = false;
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.employeeToolStripMenuItem.Text = "&Employee";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.changePasswordToolStripMenuItem.Text = "Change &Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // addUpdateEmployeeToolStripMenuItem
            // 
            this.addUpdateEmployeeToolStripMenuItem.Enabled = false;
            this.addUpdateEmployeeToolStripMenuItem.Name = "addUpdateEmployeeToolStripMenuItem";
            this.addUpdateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.addUpdateEmployeeToolStripMenuItem.Text = "Add/Update E&mployee";
            this.addUpdateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addUpdateEmployeeToolStripMenuItem_Click);
            // 
            // login
            // 
            this.login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(79, 23);
            this.login.Text = "Login_label";
            this.login.Visible = false;
            // 
            // adminReportsToolStripMenuItem
            // 
            this.adminReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.furnitureReportToolStripMenuItem,
            this.rentalReportToolStripMenuItem,
            this.returnReportToolStripMenuItem,
            this.memberReportToolStripMenuItem,
            this.employeeReportToolStripMenuItem});
            this.adminReportsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.adminReportsToolStripMenuItem.Name = "adminReportsToolStripMenuItem";
            this.adminReportsToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.adminReportsToolStripMenuItem.Text = "Admin &Reports";
            // 
            // furnitureReportToolStripMenuItem
            // 
            this.furnitureReportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.furnitureReportToolStripMenuItem.Name = "furnitureReportToolStripMenuItem";
            this.furnitureReportToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.furnitureReportToolStripMenuItem.Text = "&Furniture Report";

            this.furnitureReportToolStripMenuItem.Click += new System.EventHandler(this.furnitureReportToolStripMenuItem_Click);
            // 
            // rentalReportToolStripMenuItem
            // 
            this.rentalReportToolStripMenuItem.Name = "rentalReportToolStripMenuItem";
            this.rentalReportToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.rentalReportToolStripMenuItem.Text = "&Rental Report";
            this.rentalReportToolStripMenuItem.Click += new System.EventHandler(this.rentalReportToolStripMenuItem_Click);
            // 
            // returnReportToolStripMenuItem
            // 
            this.returnReportToolStripMenuItem.Name = "returnReportToolStripMenuItem";
            this.returnReportToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.returnReportToolStripMenuItem.Text = "Re&turn Report";
            this.returnReportToolStripMenuItem.Click += new System.EventHandler(this.returnReportToolStripMenuItem_Click);
            // 
            // memberReportToolStripMenuItem
            // 
            this.memberReportToolStripMenuItem.Name = "memberReportToolStripMenuItem";
            this.memberReportToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.memberReportToolStripMenuItem.Text = "&Member Report";
            this.memberReportToolStripMenuItem.Click += new System.EventHandler(this.memberReportToolStripMenuItem_Click);
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.employeeReportToolStripMenuItem.Text = "&Employee Report";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentItemsToolStripMenuItem,
            this.returnItemsToolStripMenuItem});
            this.actionsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // rentItemsToolStripMenuItem
            // 
            this.rentItemsToolStripMenuItem.Name = "rentItemsToolStripMenuItem";
            this.rentItemsToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.rentItemsToolStripMenuItem.Text = "Rent Items";
            this.rentItemsToolStripMenuItem.Click += new System.EventHandler(this.rentItemsToolStripMenuItem_Click);
            // 
            // returnItemsToolStripMenuItem
            // 
            this.returnItemsToolStripMenuItem.Name = "returnItemsToolStripMenuItem";
            this.returnItemsToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.returnItemsToolStripMenuItem.Text = "Return Items";
            this.returnItemsToolStripMenuItem.Click += new System.EventHandler(this.returnItemsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentalItemsToolStripMenuItem,
            this.returnItemsToolStripMenuItem1});
            this.historyToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // rentalItemsToolStripMenuItem
            // 
            this.rentalItemsToolStripMenuItem.Name = "rentalItemsToolStripMenuItem";
            this.rentalItemsToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.rentalItemsToolStripMenuItem.Text = "Rental Items";
            this.rentalItemsToolStripMenuItem.Click += new System.EventHandler(this.rentalItemsToolStripMenuItem_Click);
            // 
            // returnItemsToolStripMenuItem1
            // 
            this.returnItemsToolStripMenuItem1.Name = "returnItemsToolStripMenuItem1";
            this.returnItemsToolStripMenuItem1.Size = new System.Drawing.Size(161, 24);
            this.returnItemsToolStripMenuItem1.Text = "Return Items";
            this.returnItemsToolStripMenuItem1.Click += new System.EventHandler(this.returnItemsToolStripMenuItem1_Click);
            // 
            // MDIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 631);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIView";
            this.Text = "MDIView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem login;
        private System.Windows.Forms.ToolStripMenuItem adminReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnitureReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnItemsToolStripMenuItem1;
    }
}