namespace RentMe.Views
{
    partial class ItemReturnView
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
            System.Windows.Forms.Label homePhoneLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dataGridRentedItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.mtxtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturnItems = new System.Windows.Forms.Button();
            homePhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            homePhoneLabel.Location = new System.Drawing.Point(110, 180);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new System.Drawing.Size(117, 19);
            homePhoneLabel.TabIndex = 103;
            homePhoneLabel.Text = "Phone Number:";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomerFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFirstName.Location = new System.Drawing.Point(242, 138);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(193, 27);
            this.txtCustomerFirstName.TabIndex = 7;
            this.txtCustomerFirstName.Tag = "Customer First Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(68, 141);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(159, 19);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "Customer First Name: ";
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(340, 67);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(273, 39);
            this.lblFurnitureInfo.TabIndex = 61;
            this.lblFurnitureInfo.Text = "Return Information";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetRecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecord.Location = new System.Drawing.Point(205, 496);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(119, 31);
            this.btnGetRecord.TabIndex = 94;
            this.btnGetRecord.Text = "Get Record";
            this.btnGetRecord.UseVisualStyleBackColor = true;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecord_Click);
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomerLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLastName.Location = new System.Drawing.Point(676, 138);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(175, 27);
            this.txtCustomerLastName.TabIndex = 95;
            this.txtCustomerLastName.Tag = "Customer Last Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(513, 141);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(157, 19);
            this.lblLastName.TabIndex = 96;
            this.lblLastName.Text = "Customer Last Name: ";
            // 
            // dataGridRentedItems
            // 
            this.dataGridRentedItems.AllowUserToAddRows = false;
            this.dataGridRentedItems.AllowUserToDeleteRows = false;
            this.dataGridRentedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridRentedItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRentedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRentedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentedItems.Location = new System.Drawing.Point(12, 281);
            this.dataGridRentedItems.Name = "dataGridRentedItems";
            this.dataGridRentedItems.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRentedItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridRentedItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRentedItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridRentedItems.Size = new System.Drawing.Size(907, 192);
            this.dataGridRentedItems.TabIndex = 97;
            this.dataGridRentedItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRentedItems_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 98;
            this.label1.Text = "Rented Items";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(641, 496);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 102;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mtxtHomePhone
            // 
            this.mtxtHomePhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtxtHomePhone.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtxtHomePhone.Location = new System.Drawing.Point(242, 177);
            this.mtxtHomePhone.Mask = "(999) 000-0000";
            this.mtxtHomePhone.Name = "mtxtHomePhone";
            this.mtxtHomePhone.Size = new System.Drawing.Size(193, 27);
            this.mtxtHomePhone.TabIndex = 104;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(520, 496);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(91, 31);
            this.btnRestart.TabIndex = 105;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(390, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturnItems
            // 
            this.btnReturnItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturnItems.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnItems.Location = new System.Drawing.Point(354, 496);
            this.btnReturnItems.Name = "btnReturnItems";
            this.btnReturnItems.Size = new System.Drawing.Size(136, 31);
            this.btnReturnItems.TabIndex = 106;
            this.btnReturnItems.Text = "Return Item(s)";
            this.btnReturnItems.UseVisualStyleBackColor = true;
            // 
            // ItemReturnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(931, 550);
            this.Controls.Add(this.btnReturnItems);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(homePhoneLabel);
            this.Controls.Add(this.mtxtHomePhone);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRentedItems);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnGetRecord);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "ItemReturnView";
            this.Text = "Return View";
            this.Load += new System.EventHandler(this.ItemReturnView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetRecord;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DataGridView dataGridRentedItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox mtxtHomePhone;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnReturnItems;
    }
}