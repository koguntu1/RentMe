namespace RentMe.Views
{
    partial class ChangePasswordView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordView));
            this.lblPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.mtxtCurrentPassword = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.mtxtConfirmPassword = new System.Windows.Forms.MaskedTextBox();
            this.ttPassword = new System.Windows.Forms.ToolTip(this.components);
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(148, 55);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(312, 49);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Change Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(331, 268);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 38);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(172, 268);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 38);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPassword.Location = new System.Drawing.Point(113, 123);
            this.lblCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(166, 24);
            this.lblCurrentPassword.TabIndex = 18;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.Location = new System.Drawing.Point(113, 164);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(140, 24);
            this.lblNewPassword.TabIndex = 19;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(113, 204);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(169, 24);
            this.lblConfirmPassword.TabIndex = 20;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // mtxtCurrentPassword
            // 
            this.mtxtCurrentPassword.Font = new System.Drawing.Font("Calibri", 11F);
            this.mtxtCurrentPassword.Location = new System.Drawing.Point(311, 123);
            this.mtxtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtCurrentPassword.Name = "mtxtCurrentPassword";
            this.mtxtCurrentPassword.PasswordChar = '*';
            this.mtxtCurrentPassword.Size = new System.Drawing.Size(204, 30);
            this.mtxtCurrentPassword.TabIndex = 21;
            this.ttPassword.SetToolTip(this.mtxtCurrentPassword, "8-20 Characters Required");
            // 
            // mtxtNewPassword
            // 
            this.mtxtNewPassword.Font = new System.Drawing.Font("Calibri", 11F);
            this.mtxtNewPassword.Location = new System.Drawing.Point(311, 161);
            this.mtxtNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtNewPassword.Name = "mtxtNewPassword";
            this.mtxtNewPassword.PasswordChar = '*';
            this.mtxtNewPassword.Size = new System.Drawing.Size(204, 30);
            this.mtxtNewPassword.TabIndex = 22;
            // 
            // mtxtConfirmPassword
            // 
            this.mtxtConfirmPassword.Font = new System.Drawing.Font("Calibri", 11F);
            this.mtxtConfirmPassword.Location = new System.Drawing.Point(311, 202);
            this.mtxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtConfirmPassword.Name = "mtxtConfirmPassword";
            this.mtxtConfirmPassword.PasswordChar = '*';
            this.mtxtConfirmPassword.Size = new System.Drawing.Size(204, 30);
            this.mtxtConfirmPassword.TabIndex = 23;
            // 
            // ttPassword
            // 
            this.ttPassword.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttPassword.ToolTipTitle = "Tip";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.Location = new System.Drawing.Point(20, 37);
            this.lblLoggedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(80, 18);
            this.lblLoggedIn.TabIndex = 42;
            this.lblLoggedIn.Text = "lblLoggedIn";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(16, 15);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(99, 18);
            this.lblUser.TabIndex = 41;
            this.lblUser.Text = "Logged In User";
            // 
            // ChangePasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 321);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mtxtConfirmPassword);
            this.Controls.Add(this.mtxtNewPassword);
            this.Controls.Add(this.mtxtCurrentPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPassword);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePasswordView";
            this.Text = "ChangePasswordView";
            this.Load += new System.EventHandler(this.ChangePasswordView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.MaskedTextBox mtxtCurrentPassword;
        private System.Windows.Forms.ToolTip ttPassword;
        private System.Windows.Forms.MaskedTextBox mtxtNewPassword;
        private System.Windows.Forms.MaskedTextBox mtxtConfirmPassword;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblUser;
    }
}