namespace RentMe.Views
{
    partial class RentFurnitureForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.mtxtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtEmployeeHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeMInitial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMInitial = new System.Windows.Forms.TextBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.memberTableAdapter = new RentMe.RentMeDataSetTableAdapters.MemberTableAdapter();
            this.dtRentalDate = new System.Windows.Forms.DateTimePicker();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(242, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "MI";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(8, 223);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(240, 27);
            this.txtLastName.TabIndex = 34;
            this.txtLastName.Tag = "Last Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(8, 201);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 19);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(9, 170);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(240, 27);
            this.txtFName.TabIndex = 32;
            this.txtFName.Tag = "First Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(5, 148);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(82, 19);
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "First Name";
            // 
            // mtxtHomePhone
            // 
            this.mtxtHomePhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtHomePhone.Location = new System.Drawing.Point(10, 279);
            this.mtxtHomePhone.Mask = "(999) 000-0000";
            this.mtxtHomePhone.Name = "mtxtHomePhone";
            this.mtxtHomePhone.ReadOnly = true;
            this.mtxtHomePhone.Size = new System.Drawing.Size(331, 27);
            this.mtxtHomePhone.TabIndex = 38;
            this.mtxtHomePhone.Tag = "Home Phone Number";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 252);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(157, 19);
            this.lblPhoneNumber.TabIndex = 39;
            this.lblPhoneNumber.Text = "Home Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Rental Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Expected Return Date";
            // 
            // mtxtEmployeeHomePhone
            // 
            this.mtxtEmployeeHomePhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtEmployeeHomePhone.Location = new System.Drawing.Point(382, 224);
            this.mtxtEmployeeHomePhone.Mask = "(999) 000-0000";
            this.mtxtEmployeeHomePhone.Name = "mtxtEmployeeHomePhone";
            this.mtxtEmployeeHomePhone.ReadOnly = true;
            this.mtxtEmployeeHomePhone.Size = new System.Drawing.Size(331, 27);
            this.mtxtEmployeeHomePhone.TabIndex = 52;
            this.mtxtEmployeeHomePhone.Tag = "Home Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Home Phone Number";
            // 
            // txtEmployeeMInitial
            // 
            this.txtEmployeeMInitial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeMInitial.Location = new System.Drawing.Point(630, 117);
            this.txtEmployeeMInitial.Name = "txtEmployeeMInitial";
            this.txtEmployeeMInitial.ReadOnly = true;
            this.txtEmployeeMInitial.Size = new System.Drawing.Size(76, 27);
            this.txtEmployeeMInitial.TabIndex = 47;
            this.txtEmployeeMInitial.Tag = "MI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(626, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "MI";
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLastName.Location = new System.Drawing.Point(381, 170);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.ReadOnly = true;
            this.txtEmployeeLastName.Size = new System.Drawing.Size(240, 27);
            this.txtEmployeeLastName.TabIndex = 48;
            this.txtEmployeeLastName.Tag = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Last Name";
            // 
            // txtEmployeeFName
            // 
            this.txtEmployeeFName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeFName.Location = new System.Drawing.Point(382, 117);
            this.txtEmployeeFName.Name = "txtEmployeeFName";
            this.txtEmployeeFName.ReadOnly = true;
            this.txtEmployeeFName.Size = new System.Drawing.Size(240, 27);
            this.txtEmployeeFName.TabIndex = 46;
            this.txtEmployeeFName.Tag = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Customer ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(380, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Employee Information";
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(242, 476);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(91, 31);
            this.btnRent.TabIndex = 57;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(360, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 59;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMInitial
            // 
            this.txtMInitial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMInitial.Location = new System.Drawing.Point(257, 170);
            this.txtMInitial.Name = "txtMInitial";
            this.txtMInitial.ReadOnly = true;
            this.txtMInitial.Size = new System.Drawing.Size(76, 27);
            this.txtMInitial.TabIndex = 33;
            this.txtMInitial.Tag = "MI";
            // 
            // cbID
            // 
            this.cbID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.memberBindingSource, "memberID", true));
            this.cbID.DataSource = this.memberBindingSource;
            this.cbID.DisplayMember = "memberID";
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(107, 85);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(97, 21);
            this.cbID.TabIndex = 60;
            this.cbID.ValueMember = "memberID";
            this.cbID.SelectionChangeCommitted += new System.EventHandler(this.cbID_SelectionChangeCommitted);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.rentMeDataSet;
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // dtRentalDate
            // 
            this.dtRentalDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRentalDate.Location = new System.Drawing.Point(14, 338);
            this.dtRentalDate.Name = "dtRentalDate";
            this.dtRentalDate.Size = new System.Drawing.Size(272, 27);
            this.dtRentalDate.TabIndex = 61;
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturnDate.Location = new System.Drawing.Point(14, 390);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(272, 27);
            this.dtReturnDate.TabIndex = 62;
            // 
            // RentFurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 553);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.dtRentalDate);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtEmployeeHomePhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeMInitial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployeeFName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtHomePhone);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtMInitial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RentFurnitureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RentFurnitureFormcs";
            this.Load += new System.EventHandler(this.RentFurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.MaskedTextBox mtxtHomePhone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtEmployeeHomePhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeMInitial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeFName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMInitial;
        private System.Windows.Forms.ComboBox cbID;
        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private RentMeDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DateTimePicker dtRentalDate;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
    }
}