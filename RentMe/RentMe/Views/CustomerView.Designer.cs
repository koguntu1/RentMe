namespace RentMe.Views
{
    partial class CustomerView
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
            this.lblAuthorized = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.cboStreetType = new System.Windows.Forms.ComboBox();
            this.streetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.lblStreetType = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.mtStreetNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.mtextDOB = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.streetsTableAdapter = new RentMe.RentMeDataSetTableAdapters.StreetsTableAdapter();
            this.statesTableAdapter = new RentMe.RentMeDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new RentMe.RentMeDataSetTableAdapters.TableAdapterManager();
            this.lblStateInfo = new System.Windows.Forms.Label();
            this.lblStreetInfo = new System.Windows.Forms.Label();
            this.genderTableAdapter = new RentMe.RentMeDataSetTableAdapters.GenderTableAdapter();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new RentMe.RentMeDataSetTableAdapters.EmployeeTableAdapter();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(226, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAuthorized
            // 
            this.lblAuthorized.AutoSize = true;
            this.lblAuthorized.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorized.Location = new System.Drawing.Point(148, 59);
            this.lblAuthorized.Name = "lblAuthorized";
            this.lblAuthorized.Size = new System.Drawing.Size(311, 39);
            this.lblAuthorized.TabIndex = 5;
            this.lblAuthorized.Text = "Customer Information";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 103);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(82, 19);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(16, 125);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(240, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(345, 125);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(240, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(344, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 19);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNumber.Location = new System.Drawing.Point(12, 156);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(111, 19);
            this.lblStreetNumber.TabIndex = 10;
            this.lblStreetNumber.Text = "Street Number";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetName.Location = new System.Drawing.Point(141, 178);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(318, 27);
            this.txtStreetName.TabIndex = 5;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(137, 156);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(95, 19);
            this.lblStreetName.TabIndex = 12;
            this.lblStreetName.Text = "Street Name";
            // 
            // cboStreetType
            // 
            this.cboStreetType.DataSource = this.streetsBindingSource;
            this.cboStreetType.DisplayMember = "abbreviation";
            this.cboStreetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreetType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreetType.FormattingEnabled = true;
            this.cboStreetType.Location = new System.Drawing.Point(465, 178);
            this.cboStreetType.Name = "cboStreetType";
            this.cboStreetType.Size = new System.Drawing.Size(119, 27);
            this.cboStreetType.TabIndex = 6;
            this.cboStreetType.ValueMember = "abbreviation";
            this.cboStreetType.SelectedIndexChanged += new System.EventHandler(this.cboStreetType_SelectedIndexChanged);
            // 
            // streetsBindingSource
            // 
            this.streetsBindingSource.DataMember = "Streets";
            this.streetsBindingSource.DataSource = this.rentMeDataSet;
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStreetType
            // 
            this.lblStreetType.AutoSize = true;
            this.lblStreetType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetType.Location = new System.Drawing.Point(461, 155);
            this.lblStreetType.Name = "lblStreetType";
            this.lblStreetType.Size = new System.Drawing.Size(88, 19);
            this.lblStreetType.TabIndex = 15;
            this.lblStreetType.Text = "Street Type";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(16, 279);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(331, 27);
            this.txtCity.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(12, 257);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 19);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(462, 257);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(68, 19);
            this.lblZipCode.TabIndex = 18;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(349, 256);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 19);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State";
            // 
            // cboState
            // 
            this.cboState.DataSource = this.statesBindingSource;
            this.cboState.DisplayMember = "abbreviation";
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(353, 279);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(106, 27);
            this.cboState.TabIndex = 9;
            this.cboState.ValueMember = "abbreviation";
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.rentMeDataSet;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(11, 309);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(157, 19);
            this.lblPhoneNumber.TabIndex = 22;
            this.lblPhoneNumber.Text = "Home Phone Number";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(16, 227);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(568, 27);
            this.txtAddress2.TabIndex = 7;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(12, 205);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(223, 19);
            this.lblAddress2.TabIndex = 24;
            this.lblAddress2.Text = "Additional Address Information";
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(262, 125);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(76, 27);
            this.txtMiddleInitial.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "MI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Gender";
            // 
            // cboGender
            // 
            this.cboGender.DataSource = this.genderBindingSource;
            this.cboGender.DisplayMember = "gender";
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(478, 334);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(106, 27);
            this.cboGender.TabIndex = 12;
            this.cboGender.ValueMember = "gender";
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.rentMeDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Date of Birth";
            // 
            // mtStreetNumber
            // 
            this.mtStreetNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtStreetNumber.Location = new System.Drawing.Point(16, 178);
            this.mtStreetNumber.Mask = "000000";
            this.mtStreetNumber.Name = "mtStreetNumber";
            this.mtStreetNumber.Size = new System.Drawing.Size(119, 27);
            this.mtStreetNumber.TabIndex = 4;
            this.mtStreetNumber.ValidatingType = typeof(int);
            // 
            // mtxtZipCode
            // 
            this.mtxtZipCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtZipCode.Location = new System.Drawing.Point(465, 279);
            this.mtxtZipCode.Mask = "00000-9999";
            this.mtxtZipCode.Name = "mtxtZipCode";
            this.mtxtZipCode.Size = new System.Drawing.Size(119, 27);
            this.mtxtZipCode.TabIndex = 10;
            // 
            // mtxtHomePhone
            // 
            this.mtxtHomePhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtHomePhone.Location = new System.Drawing.Point(16, 334);
            this.mtxtHomePhone.Mask = "(999) 000-0000";
            this.mtxtHomePhone.Name = "mtxtHomePhone";
            this.mtxtHomePhone.Size = new System.Drawing.Size(331, 27);
            this.mtxtHomePhone.TabIndex = 11;
            // 
            // mtextDOB
            // 
            this.mtextDOB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtextDOB.Location = new System.Drawing.Point(15, 393);
            this.mtextDOB.Mask = "00/00/0000";
            this.mtextDOB.Name = "mtextDOB";
            this.mtextDOB.Size = new System.Drawing.Size(332, 27);
            this.mtextDOB.TabIndex = 13;
            this.mtextDOB.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // streetsTableAdapter
            // 
            this.streetsTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
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
            // lblStateInfo
            // 
            this.lblStateInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateInfo.Location = new System.Drawing.Point(174, 313);
            this.lblStateInfo.Name = "lblStateInfo";
            this.lblStateInfo.Size = new System.Drawing.Size(285, 15);
            this.lblStateInfo.TabIndex = 36;
            this.lblStateInfo.Text = "lblStateInfo";
            this.lblStateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreetInfo
            // 
            this.lblStreetInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetInfo.Location = new System.Drawing.Point(299, 209);
            this.lblStreetInfo.Name = "lblStreetInfo";
            this.lblStreetInfo.Size = new System.Drawing.Size(285, 15);
            this.lblStreetInfo.TabIndex = 37;
            this.lblStreetInfo.Text = "lblStreetInfo";
            this.lblStreetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(299, 364);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(285, 15);
            this.lblGender.TabIndex = 38;
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(16, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 14);
            this.lblUser.TabIndex = 39;
            this.lblUser.Text = "Logged In User";
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
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.Location = new System.Drawing.Point(19, 31);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(71, 14);
            this.lblLoggedIn.TabIndex = 40;
            this.lblLoggedIn.Text = "lblLoggedIn";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 537);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblStreetInfo);
            this.Controls.Add(this.lblStateInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtextDOB);
            this.Controls.Add(this.mtxtHomePhone);
            this.Controls.Add(this.mtxtZipCode);
            this.Controls.Add(this.mtStreetNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetType);
            this.Controls.Add(this.cboStreetType);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.lblStreetNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAuthorized);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerView";
            this.Text = "CustomerRegistrationView";
            this.Load += new System.EventHandler(this.CustomerRegistrationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAuthorized;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.ComboBox cboStreetType;
        private System.Windows.Forms.Label lblStreetType;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtStreetNumber;
        private System.Windows.Forms.MaskedTextBox mtxtZipCode;
        private System.Windows.Forms.MaskedTextBox mtxtHomePhone;
        private System.Windows.Forms.MaskedTextBox mtextDOB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private RentMeDataSetTableAdapters.StreetsTableAdapter streetsTableAdapter;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private RentMeDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private RentMeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblStateInfo;
        private System.Windows.Forms.Label lblStreetInfo;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private RentMeDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private RentMeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label lblLoggedIn;
    }
}