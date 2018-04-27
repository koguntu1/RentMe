namespace RentMe.Views
{
    partial class CusView
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
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label homePhoneLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.mtxtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMember = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            homePhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            fnameLabel.Location = new System.Drawing.Point(69, 116);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(86, 19);
            fnameLabel.TabIndex = 2;
            fnameLabel.Text = "First Name:";
            // 
            // lnameLabel
            // 
            lnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lnameLabel.Location = new System.Drawing.Point(444, 116);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(84, 19);
            lnameLabel.TabIndex = 4;
            lnameLabel.Text = "Last Name:";
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            homePhoneLabel.Location = new System.Drawing.Point(69, 154);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new System.Drawing.Size(117, 19);
            homePhoneLabel.TabIndex = 6;
            homePhoneLabel.Text = "Phone Number:";
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.memberDataGridView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memberDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.memberDataGridView.Location = new System.Drawing.Point(12, 199);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.Size = new System.Drawing.Size(856, 220);
            this.memberDataGridView.TabIndex = 1;
            this.memberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberDataGridView_CellContentClick);
            // 
            // txtFname
            // 
            this.txtFname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFname.Location = new System.Drawing.Point(190, 113);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(201, 27);
            this.txtFname.TabIndex = 0;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeView_KeyPress);
            // 
            // txtLname
            // 
            this.txtLname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtLname.Location = new System.Drawing.Point(532, 113);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(210, 27);
            this.txtLname.TabIndex = 5;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeView_KeyPress);
            // 
            // mtxtHomePhone
            // 
            this.mtxtHomePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtxtHomePhone.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtxtHomePhone.Location = new System.Drawing.Point(192, 151);
            this.mtxtHomePhone.Mask = "(999) 000-0000";
            this.mtxtHomePhone.Name = "mtxtHomePhone";
            this.mtxtHomePhone.Size = new System.Drawing.Size(199, 27);
            this.mtxtHomePhone.TabIndex = 7;
            this.mtxtHomePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeView_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(212, 473);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(352, 473);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 31);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(632, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(492, 473);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(91, 31);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(371, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // lblMember
            // 
            this.lblMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(277, 45);
            this.lblMember.MaximumSize = new System.Drawing.Size(500, 50);
            this.lblMember.MinimumSize = new System.Drawing.Size(350, 50);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(350, 50);
            this.lblMember.TabIndex = 52;
            this.lblMember.Text = "Search for an Customer";
            this.lblMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 539);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(homePhoneLabel);
            this.Controls.Add(this.mtxtHomePhone);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.memberDataGridView);
            this.Name = "CusView";
            this.Text = "Member Search";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.MaskedTextBox mtxtHomePhone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMember;
    }
}