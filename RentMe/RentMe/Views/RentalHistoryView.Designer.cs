namespace RentMe.Views
{
    partial class RentalHistoryView
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
            System.Windows.Forms.Label lblItemID;
            System.Windows.Forms.Label lblFurnitureID;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.cboMemberID = new System.Windows.Forms.ComboBox();
            this.cboEmployeeID = new System.Windows.Forms.ComboBox();
            this.tpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridViewRentItem = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lblItemID = new System.Windows.Forms.Label();
            lblFurnitureID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(336, 58);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(205, 39);
            this.lblFurnitureInfo.TabIndex = 58;
            this.lblFurnitureInfo.Text = "Rental History";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMemberID
            // 
            this.cboMemberID.AllowDrop = true;
            this.cboMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboMemberID.FormattingEnabled = true;
            this.cboMemberID.Location = new System.Drawing.Point(110, 120);
            this.cboMemberID.Name = "cboMemberID";
            this.cboMemberID.Size = new System.Drawing.Size(260, 27);
            this.cboMemberID.TabIndex = 59;
            this.cboMemberID.Tag = "Customer ID";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblItemID.Location = new System.Drawing.Point(436, 128);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new System.Drawing.Size(80, 19);
            lblItemID.TabIndex = 62;
            lblItemID.Text = "Employee:";
            // 
            // cboEmployeeID
            // 
            this.cboEmployeeID.AllowDrop = true;
            this.cboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeeID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboEmployeeID.FormattingEnabled = true;
            this.cboEmployeeID.Location = new System.Drawing.Point(522, 120);
            this.cboEmployeeID.Name = "cboEmployeeID";
            this.cboEmployeeID.Size = new System.Drawing.Size(279, 27);
            this.cboEmployeeID.TabIndex = 60;
            this.cboEmployeeID.Tag = "Employee ID";
            // 
            // lblFurnitureID
            // 
            lblFurnitureID.AutoSize = true;
            lblFurnitureID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblFurnitureID.Location = new System.Drawing.Point(26, 128);
            lblFurnitureID.Name = "lblFurnitureID";
            lblFurnitureID.Size = new System.Drawing.Size(78, 19);
            lblFurnitureID.TabIndex = 61;
            lblFurnitureID.Text = "Customer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(26, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 19);
            label1.TabIndex = 63;
            label1.Text = "Rent Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(26, 212);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 19);
            label2.TabIndex = 64;
            label2.Text = "From:";
            // 
            // tpFromDate
            // 
            this.tpFromDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.tpFromDate.Location = new System.Drawing.Point(110, 206);
            this.tpFromDate.Name = "tpFromDate";
            this.tpFromDate.Size = new System.Drawing.Size(260, 27);
            this.tpFromDate.TabIndex = 65;
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtToDate.Location = new System.Drawing.Point(522, 206);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(279, 27);
            this.dtToDate.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(487, 212);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 19);
            label3.TabIndex = 66;
            label3.Text = "To:";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(425, 498);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(91, 31);
            this.btnRestart.TabIndex = 70;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(135, 498);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 68;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(733, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 69;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridViewRentItem
            // 
            this.dataGridViewRentItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentItem.Location = new System.Drawing.Point(30, 253);
            this.dataGridViewRentItem.Name = "dataGridViewRentItem";
            this.dataGridViewRentItem.Size = new System.Drawing.Size(803, 227);
            this.dataGridViewRentItem.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(359, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // RentalHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 541);
            this.Controls.Add(this.dataGridViewRentItem);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(label3);
            this.Controls.Add(this.tpFromDate);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cboMemberID);
            this.Controls.Add(lblItemID);
            this.Controls.Add(this.cboEmployeeID);
            this.Controls.Add(lblFurnitureID);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RentalHistoryView";
            this.Text = "Rental History View";
            this.Load += new System.EventHandler(this.RentalHistoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboMemberID;
        private System.Windows.Forms.ComboBox cboEmployeeID;
        private System.Windows.Forms.DateTimePicker tpFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridViewRentItem;
    }
}