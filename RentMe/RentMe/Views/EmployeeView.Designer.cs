namespace RentMe.Views
{
    partial class EmployeeView
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
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label adminLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label homePhoneLabel;
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new RentMe.RentMeDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new RentMe.RentMeDataSetTableAdapters.TableAdapterManager();
            this.genderTableAdapter = new RentMe.RentMeDataSetTableAdapters.GenderTableAdapter();
            this.statesTableAdapter = new RentMe.RentMeDataSetTableAdapters.StatesTableAdapter();
            this.streetsTableAdapter = new RentMe.RentMeDataSetTableAdapters.StreetsTableAdapter();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.tpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboAdmin = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxtZip = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.streetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblStateInfo = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            middleInitialLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            adminLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            homePhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.Location = new System.Drawing.Point(39, 106);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(86, 19);
            fnameLabel.TabIndex = 85;
            fnameLabel.Text = "First Name:";
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
            lnameLabel.Size = new System.Drawing.Size(84, 19);
            lnameLabel.TabIndex = 89;
            lnameLabel.Text = "Last Name:";
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
            address1Label.Location = new System.Drawing.Point(15, 150);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(113, 19);
            address1Label.TabIndex = 95;
            address1Label.Text = "Street Address:";
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
            cityLabel.Size = new System.Drawing.Size(39, 19);
            cityLabel.TabIndex = 99;
            cityLabel.Text = "City:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(415, 283);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(63, 19);
            genderLabel.TabIndex = 105;
            genderLabel.Text = "Gender:";
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adminLabel.Location = new System.Drawing.Point(415, 334);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new System.Drawing.Size(58, 19);
            adminLabel.TabIndex = 107;
            adminLabel.Text = "Admin:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(334, 243);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(49, 19);
            stateLabel.TabIndex = 108;
            stateLabel.Text = "State:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postalCodeLabel.Location = new System.Drawing.Point(440, 243);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(34, 19);
            postalCodeLabel.TabIndex = 109;
            postalCodeLabel.Text = "Zip:";
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            homePhoneLabel.Location = new System.Drawing.Point(21, 283);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new System.Drawing.Size(101, 19);
            homePhoneLabel.TabIndex = 110;
            homePhoneLabel.Text = "Home Phone:";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(386, 382);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(91, 31);
            this.btnRestart.TabIndex = 16;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(24, 382);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(143, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 31);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(500, 382);
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
            this.btnSubmit.Location = new System.Drawing.Point(268, 382);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 31);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(148, 44);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(314, 39);
            this.lblEmployee.TabIndex = 50;
            this.lblEmployee.Text = "Employee Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(226, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
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
            this.tableAdapterManager.GenderTableAdapter = this.genderTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.Rental_return_transactionTableAdapter = null;
            this.tableAdapterManager.Rental_transactionTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.Store_itemTableAdapter = null;
            this.tableAdapterManager.StreetsTableAdapter = this.streetsTableAdapter;
            this.tableAdapterManager.StyleTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentMe.RentMeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // streetsTableAdapter
            // 
            this.streetsTableAdapter.ClearBeforeFill = true;
            // 
            // txtFname
            // 
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "fname", true));
            this.txtFname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFname.Location = new System.Drawing.Point(131, 101);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(125, 27);
            this.txtFname.TabIndex = 1;
            // 
            // txtMI
            // 
            this.txtMI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "middleInitial", true));
            this.txtMI.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtMI.Location = new System.Drawing.Point(315, 101);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(44, 27);
            this.txtMI.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "lname", true));
            this.txtLname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtLname.Location = new System.Drawing.Point(454, 101);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(125, 27);
            this.txtLname.TabIndex = 3;
            // 
            // tpBirthDate
            // 
            this.tpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "dateOfBirth", true));
            this.tpBirthDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.tpBirthDate.Location = new System.Drawing.Point(128, 329);
            this.tpBirthDate.Name = "tpBirthDate";
            this.tpBirthDate.Size = new System.Drawing.Size(281, 27);
            this.tpBirthDate.TabIndex = 11;
            // 
            // txtAddress1
            // 
            this.txtAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address1", true));
            this.txtAddress1.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtAddress1.Location = new System.Drawing.Point(128, 147);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(451, 27);
            this.txtAddress1.TabIndex = 4;
            // 
            // txtAddress2
            // 
            this.txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address2", true));
            this.txtAddress2.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtAddress2.Location = new System.Drawing.Point(128, 190);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(451, 27);
            this.txtAddress2.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "City", true));
            this.txtCity.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtCity.Location = new System.Drawing.Point(128, 235);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 27);
            this.txtCity.TabIndex = 6;
            // 
            // cboGender
            // 
            this.cboGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "gender", true));
            this.cboGender.DataSource = this.genderBindingSource;
            this.cboGender.DisplayMember = "gender";
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(479, 280);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 27);
            this.cboGender.TabIndex = 10;
            this.cboGender.ValueMember = "gender";
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.rentMeDataSet;
            // 
            // cboAdmin
            // 
            this.cboAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "admin", true));
            this.cboAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdmin.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboAdmin.FormattingEnabled = true;
            this.cboAdmin.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cboAdmin.Location = new System.Drawing.Point(479, 332);
            this.cboAdmin.Name = "cboAdmin";
            this.cboAdmin.Size = new System.Drawing.Size(100, 27);
            this.cboAdmin.TabIndex = 12;
            // 
            // cboState
            // 
            this.cboState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "State", true));
            this.cboState.DataSource = this.statesBindingSource;
            this.cboState.DisplayMember = "abbreviation";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(386, 235);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(48, 27);
            this.cboState.TabIndex = 7;
            this.cboState.ValueMember = "abbreviation";
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.rentMeDataSet;
            // 
            // mtxtZip
            // 
            this.mtxtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PostalCode", true));
            this.mtxtZip.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtxtZip.Location = new System.Drawing.Point(479, 235);
            this.mtxtZip.Mask = "00000-9999";
            this.mtxtZip.Name = "mtxtZip";
            this.mtxtZip.Size = new System.Drawing.Size(100, 27);
            this.mtxtZip.TabIndex = 8;
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
            // 
            // streetsBindingSource
            // 
            this.streetsBindingSource.DataMember = "Streets";
            this.streetsBindingSource.DataSource = this.rentMeDataSet;
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
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 440);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblStateInfo);
            this.Controls.Add(homePhoneLabel);
            this.Controls.Add(this.mtxtHomePhone);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.mtxtZip);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.cboState);
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
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(adminLabel);
            this.Controls.Add(this.cboAdmin);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private RentMeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private RentMeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RentMeDataSetTableAdapters.StreetsTableAdapter streetsTableAdapter;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.DateTimePicker tpBirthDate;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboAdmin;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.MaskedTextBox mtxtZip;
        private System.Windows.Forms.MaskedTextBox mtxtHomePhone;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private RentMeDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private RentMeDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.Label lblStateInfo;
        private System.Windows.Forms.Label lblGender;
    }
}