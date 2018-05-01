namespace RentMe.Views
{
    partial class ReturnFurnitureView
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAmountOwed = new System.Windows.Forms.TextBox();
            this.txtFines = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTotalOwed = new System.Windows.Forms.TextBox();
            this.dataGridItemsToReturn = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculateOwed = new System.Windows.Forms.Button();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsToReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.Location = new System.Drawing.Point(27, 126);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(86, 19);
            fnameLabel.TabIndex = 93;
            fnameLabel.Text = "First Name:";
            // 
            // lnameLabel
            // 
            lnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lnameLabel.Location = new System.Drawing.Point(315, 129);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(84, 19);
            lnameLabel.TabIndex = 95;
            lnameLabel.Text = "Last Name:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(614, 319);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(117, 19);
            label5.TabIndex = 105;
            label5.Text = "Amount Owed: ";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(629, 359);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 19);
            label11.TabIndex = 119;
            label11.Text = "Total Fines: ";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(27, 450);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 19);
            label1.TabIndex = 121;
            label1.Text = "Comments:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(622, 406);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 23);
            label2.TabIndex = 125;
            label2.Text = "Total Owed:";
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(335, 57);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(266, 39);
            this.lblFurnitureInfo.TabIndex = 63;
            this.lblFurnitureInfo.Text = "Return Transaction";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(398, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // txtFname
            // 
            this.txtFname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFname.Enabled = false;
            this.txtFname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFname.Location = new System.Drawing.Point(119, 121);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(178, 27);
            this.txtFname.TabIndex = 90;
            this.txtFname.TabStop = false;
            // 
            // txtLname
            // 
            this.txtLname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLname.Enabled = false;
            this.txtLname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtLname.Location = new System.Drawing.Point(405, 121);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(162, 27);
            this.txtLname.TabIndex = 92;
            this.txtLname.TabStop = false;
            // 
            // txtAmountOwed
            // 
            this.txtAmountOwed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmountOwed.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAmountOwed.Enabled = false;
            this.txtAmountOwed.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtAmountOwed.Location = new System.Drawing.Point(732, 316);
            this.txtAmountOwed.Name = "txtAmountOwed";
            this.txtAmountOwed.Size = new System.Drawing.Size(187, 27);
            this.txtAmountOwed.TabIndex = 102;
            this.txtAmountOwed.TabStop = false;
            // 
            // txtFines
            // 
            this.txtFines.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFines.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFines.Enabled = false;
            this.txtFines.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFines.Location = new System.Drawing.Point(732, 359);
            this.txtFines.Name = "txtFines";
            this.txtFines.Size = new System.Drawing.Size(187, 27);
            this.txtFines.TabIndex = 118;
            this.txtFines.TabStop = false;
            // 
            // txtComments
            // 
            this.txtComments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComments.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtComments.Location = new System.Drawing.Point(150, 447);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(769, 61);
            this.txtComments.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(656, 556);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 123;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(398, 556);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(197, 31);
            this.btnSubmit.TabIndex = 122;
            this.btnSubmit.Text = "Complete Transaction";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTotalOwed
            // 
            this.txtTotalOwed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotalOwed.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotalOwed.Enabled = false;
            this.txtTotalOwed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOwed.Location = new System.Drawing.Point(732, 403);
            this.txtTotalOwed.Name = "txtTotalOwed";
            this.txtTotalOwed.Size = new System.Drawing.Size(187, 31);
            this.txtTotalOwed.TabIndex = 124;
            this.txtTotalOwed.TabStop = false;
            // 
            // dataGridItemsToReturn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridItemsToReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridItemsToReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsToReturn.Location = new System.Drawing.Point(31, 160);
            this.dataGridItemsToReturn.Name = "dataGridItemsToReturn";
            this.dataGridItemsToReturn.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridItemsToReturn.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridItemsToReturn.Size = new System.Drawing.Size(888, 150);
            this.dataGridItemsToReturn.TabIndex = 126;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 324);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 27);
            this.dateTimePicker1.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 128;
            this.label3.Text = "Date Returned:";
            // 
            // btnCalculateOwed
            // 
            this.btnCalculateOwed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculateOwed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateOwed.Location = new System.Drawing.Point(150, 556);
            this.btnCalculateOwed.Name = "btnCalculateOwed";
            this.btnCalculateOwed.Size = new System.Drawing.Size(197, 31);
            this.btnCalculateOwed.TabIndex = 129;
            this.btnCalculateOwed.Text = "Calculate Total Owed";
            this.btnCalculateOwed.UseVisualStyleBackColor = true;
            this.btnCalculateOwed.Click += new System.EventHandler(this.btnCalculateOwed_Click);
            // 
            // ReturnFurnitureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 619);
            this.Controls.Add(this.btnCalculateOwed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridItemsToReturn);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtTotalOwed);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(label11);
            this.Controls.Add(this.txtFines);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtAmountOwed);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReturnFurnitureView";
            this.Text = "Return Furniture";
            this.Load += new System.EventHandler(this.ReturnFurnitureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsToReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAmountOwed;
        private System.Windows.Forms.TextBox txtFines;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTotalOwed;
        private System.Windows.Forms.DataGridView dataGridItemsToReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculateOwed;
    }
}