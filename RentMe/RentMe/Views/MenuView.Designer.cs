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
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnSearchFurniture = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
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
            this.btnAddCustomer.Location = new System.Drawing.Point(64, 61);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(176, 33);
            this.btnAddCustomer.TabIndex = 43;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(64, 103);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(176, 33);
            this.btnSearchCustomer.TabIndex = 44;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnSearchFurniture
            // 
            this.btnSearchFurniture.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFurniture.Location = new System.Drawing.Point(64, 145);
            this.btnSearchFurniture.Name = "btnSearchFurniture";
            this.btnSearchFurniture.Size = new System.Drawing.Size(176, 33);
            this.btnSearchFurniture.TabIndex = 45;
            this.btnSearchFurniture.Text = "Search Furniture";
            this.btnSearchFurniture.UseVisualStyleBackColor = true;
            this.btnSearchFurniture.Click += new System.EventHandler(this.btnSearchFurniture_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(64, 187);
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
            this.btnSearchEmployee.Location = new System.Drawing.Point(64, 226);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(176, 33);
            this.btnSearchEmployee.TabIndex = 47;
            this.btnSearchEmployee.Text = "Search Employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnSearchFurniture);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblUser);
            this.Name = "MenuView";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnSearchFurniture;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSearchEmployee;
    }
}