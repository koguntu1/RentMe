namespace RentMe.Views
{
    partial class MenuView
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
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSearchFurniture = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.Location = new System.Drawing.Point(15, 27);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(71, 14);
            this.lblLoggedIn.TabIndex = 42;
            this.lblLoggedIn.Text = "lblLoggedIn";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 14);
            this.lblUser.TabIndex = 41;
            this.lblUser.Text = "Logged In User";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(24, 61);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(245, 33);
            this.btnAddCustomer.TabIndex = 43;
            this.btnAddCustomer.Text = "Customer Maintenance";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSearchFurniture
            // 
            this.btnSearchFurniture.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFurniture.Location = new System.Drawing.Point(24, 100);
            this.btnSearchFurniture.Name = "btnSearchFurniture";
            this.btnSearchFurniture.Size = new System.Drawing.Size(245, 33);
            this.btnSearchFurniture.TabIndex = 45;
            this.btnSearchFurniture.Text = "Furniture Maintenance";
            this.btnSearchFurniture.UseVisualStyleBackColor = true;
            this.btnSearchFurniture.Click += new System.EventHandler(this.btnSearchFurniture_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(31, 22);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(176, 33);
            this.btnChangePassword.TabIndex = 46;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(31, 61);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(176, 33);
            this.btnSearchEmployee.TabIndex = 47;
            this.btnSearchEmployee.Text = "Search Employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.btnChangePassword);
            this.grpEmployee.Controls.Add(this.btnSearchEmployee);
            this.grpEmployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployee.Location = new System.Drawing.Point(24, 151);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(245, 100);
            this.grpEmployee.TabIndex = 48;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee Maintenance";
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(58, 268);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(176, 33);
            this.btnLogout.TabIndex = 49;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MenuView
            // 
            this.AcceptButton = this.btnChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.btnSearchFurniture);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblUser);
            this.Name = "MenuView";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuView_FormClosing);
            this.Load += new System.EventHandler(this.MenuView_Load);
            this.grpEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSearchFurniture;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Button btnLogout;
    }
}