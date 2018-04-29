namespace RentMe.Views
{
    partial class AddUpdateMemberView
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
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label middleInitialLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label homePhoneLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblMember = new System.Windows.Forms.Label();
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new RentMe.RentMeDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new RentMe.RentMeDataSetTableAdapters.TableAdapterManager();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.tpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxtZip = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.lblStateInfo = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.loginTableAdapter = new RentMe.RentMeDataSetTableAdapters.LoginTableAdapter();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new RentMe.RentMeDataSetTableAdapters.GenderTableAdapter();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statesTableAdapter = new RentMe.RentMeDataSetTableAdapters.StatesTableAdapter();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            middleInitialLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            homePhoneLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.Location = new System.Drawing.Point(31, 106);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(94, 19);
            fnameLabel.TabIndex = 85;
            fnameLabel.Text = "*First Name:";
            // 
            // middleInitialLabel
            // 
            middleInitialLabel.AutoSize = true;
            middleInitialLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            middleInitialLabel.Location = new System.Drawing.Point(279, 104);
            middleInitialLabel.Name = "middleInitialLabel";
            middleInitialLabel.Size = new System.Drawing.Size(31, 19);
            middleInitialLabel.TabIndex = 87;
            middleInitialLabel.Text = "MI:";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lnameLabel.Location = new System.Drawing.Point(365, 106);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(92, 19);
            lnameLabel.TabIndex = 89;
            lnameLabel.Text = "*Last Name:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfBirthLabel.Location = new System.Drawing.Point(22, 335);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(83, 19);
            dateOfBirthLabel.TabIndex = 91;
            dateOfBirthLabel.Text = "Birth Date:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address1Label.Location = new System.Drawing.Point(4, 150);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(121, 19);
            address1Label.TabIndex = 95;
            address1Label.Text = "*Street Address:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address2Label.Location = new System.Drawing.Point(15, 198);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(106, 19);
            address2Label.TabIndex = 97;
            address2Label.Text = "Address, cont:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(78, 238);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(47, 19);
            cityLabel.TabIndex = 99;
            cityLabel.Text = "*City:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postalCodeLabel.Location = new System.Drawing.Point(448, 238);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(42, 19);
            postalCodeLabel.TabIndex = 109;
            postalCodeLabel.Text = "*Zip:";
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            homePhoneLabel.Location = new System.Drawing.Point(16, 285);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new System.Drawing.Size(109, 19);
            homePhoneLabel.TabIndex = 110;
            homePhoneLabel.Text = "*Home Phone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(335, 238);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 19);
            label1.TabIndex = 118;
            label1.Text = "*State:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(461, 280);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 19);
            label2.TabIndex = 119;
            label2.Text = "*Gender:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(486, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(49, 419);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 31);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(174, 34);
            this.lblMember.MaximumSize = new System.Drawing.Size(500, 50);
            this.lblMember.MinimumSize = new System.Drawing.Size(350, 50);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(350, 50);
            this.lblMember.TabIndex = 50;
            this.lblMember.Text = "Member Information";
            this.lblMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.rentMeDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.FurnitureTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.Rental_return_transactionTableAdapter = null;
            this.tableAdapterManager.Rental_transactionTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.Store_itemTableAdapter = null;
            this.tableAdapterManager.StreetsTableAdapter = null;
            this.tableAdapterManager.StyleTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentMe.RentMeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtFname
            // 
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "fname", true));
            this.txtFname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFname.Location = new System.Drawing.Point(131, 101);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(125, 27);
            this.txtFname.TabIndex = 0;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // txtMI
            // 
            this.txtMI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "middleInitial", true));
            this.txtMI.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtMI.Location = new System.Drawing.Point(315, 101);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(44, 27);
            this.txtMI.TabIndex = 2;
            this.txtMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // txtLname
            // 
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "lname", true));
            this.txtLname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtLname.Location = new System.Drawing.Point(463, 101);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(125, 27);
            this.txtLname.TabIndex = 3;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // tpBirthDate
            // 
            this.tpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "dateOfBirth", true));
            this.tpBirthDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.tpBirthDate.Location = new System.Drawing.Point(128, 329);
            this.tpBirthDate.Name = "tpBirthDate";
            this.tpBirthDate.Size = new System.Drawing.Size(281, 27);
            this.tpBirthDate.TabIndex = 11;
            this.tpBirthDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // txtAddress1
            // 
            this.txtAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address1", true));
            this.txtAddress1.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtAddress1.Location = new System.Drawing.Point(128, 147);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(451, 27);
            this.txtAddress1.TabIndex = 4;
            this.txtAddress1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // txtAddress2
            // 
            this.txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address2", true));
            this.txtAddress2.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtAddress2.Location = new System.Drawing.Point(128, 190);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(451, 27);
            this.txtAddress2.TabIndex = 5;
            this.txtAddress2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "City", true));
            this.txtCity.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtCity.Location = new System.Drawing.Point(128, 235);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 27);
            this.txtCity.TabIndex = 6;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.rentMeDataSet;
            // 
            // mtxtZip
            // 
            this.mtxtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PostalCode", true));
            this.mtxtZip.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtxtZip.Location = new System.Drawing.Point(499, 235);
            this.mtxtZip.Mask = "00000-9999";
            this.mtxtZip.Name = "mtxtZip";
            this.mtxtZip.Size = new System.Drawing.Size(100, 27);
            this.mtxtZip.TabIndex = 8;
            this.mtxtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // mtxtHomePhone
            // 
            this.mtxtHomePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "homePhone", true));
            this.mtxtHomePhone.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtxtHomePhone.Location = new System.Drawing.Point(128, 280);
            this.mtxtHomePhone.Mask = "(999) 000-0000";
            this.mtxtHomePhone.Name = "mtxtHomePhone";
            this.mtxtHomePhone.Size = new System.Drawing.Size(200, 27);
            this.mtxtHomePhone.TabIndex = 9;
            this.mtxtHomePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // lblStateInfo
            // 
            this.lblStateInfo.AutoSize = true;
            this.lblStateInfo.Location = new System.Drawing.Point(34, 265);
            this.lblStateInfo.MinimumSize = new System.Drawing.Size(400, 13);
            this.lblStateInfo.Name = "lblStateInfo";
            this.lblStateInfo.Size = new System.Drawing.Size(400, 13);
            this.lblStateInfo.TabIndex = 112;
            this.lblStateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(476, 310);
            this.lblGender.MinimumSize = new System.Drawing.Size(100, 13);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 13);
            this.lblGender.TabIndex = 113;
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "fk_Login_Employee";
            this.loginBindingSource.DataSource = this.employeeBindingSource;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.rentMeDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // cboState
            // 
            this.cboState.DataSource = this.statesBindingSource;
            this.cboState.DisplayMember = "abbreviation";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(398, 235);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(44, 27);
            this.cboState.TabIndex = 7;
            this.cboState.ValueMember = "abbreviation";
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            this.cboState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // cboGender
            // 
            this.cboGender.DataSource = this.genderBindingSource;
            this.cboGender.DisplayMember = "gender";
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(538, 277);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(50, 27);
            this.cboGender.TabIndex = 10;
            this.cboGender.ValueMember = "gender";
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            this.cboGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUpdateEmployeeView_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Required *";
            // 
            // AddUpdateMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblStateInfo);
            this.Controls.Add(homePhoneLabel);
            this.Controls.Add(this.mtxtHomePhone);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.mtxtZip);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(middleInitialLabel);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.tpBirthDate);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMember);
            this.Name = "AddUpdateMemberView";
            this.Text = "Add/Update Member";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUpdateMemberView_FormClosing);
            this.Load += new System.EventHandler(this.MemberView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private RentMeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private RentMeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.DateTimePicker tpBirthDate;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MaskedTextBox mtxtZip;
        private System.Windows.Forms.MaskedTextBox mtxtHomePhone;
        private System.Windows.Forms.Label lblStateInfo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private RentMeDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private RentMeDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private RentMeDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label3;
    }
}