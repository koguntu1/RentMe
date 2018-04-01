namespace RentMe.Views
{
    partial class FurnitureView
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
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label styleLabel;
            System.Windows.Forms.Label dailyRateLabel;
            System.Windows.Forms.Label fineRateLabel;
            System.Windows.Forms.Label lblItemID;
            System.Windows.Forms.Label furnitureDescrptionLabel;
            System.Windows.Forms.Label lblFurnitureID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FurnitureView));
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureTableAdapter = new RentMe.RentMeDataSetTableAdapters.FurnitureTableAdapter();
            this.tableAdapterManager = new RentMe.RentMeDataSetTableAdapters.TableAdapterManager();
            this.furnitureDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFurnitureDescrption = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.store_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.store_itemTableAdapter = new RentMe.RentMeDataSetTableAdapters.Store_itemTableAdapter();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.cboFurnitureID = new System.Windows.Forms.ComboBox();
            this.mtxtDailyRate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFineRate = new System.Windows.Forms.MaskedTextBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.navFurniture = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            categoryLabel = new System.Windows.Forms.Label();
            styleLabel = new System.Windows.Forms.Label();
            dailyRateLabel = new System.Windows.Forms.Label();
            fineRateLabel = new System.Windows.Forms.Label();
            lblItemID = new System.Windows.Forms.Label();
            furnitureDescrptionLabel = new System.Windows.Forms.Label();
            lblFurnitureID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navFurniture)).BeginInit();
            this.navFurniture.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(12, 314);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(74, 19);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category:";
            // 
            // styleLabel
            // 
            styleLabel.AutoSize = true;
            styleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleLabel.Location = new System.Drawing.Point(12, 373);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new System.Drawing.Size(47, 19);
            styleLabel.TabIndex = 4;
            styleLabel.Text = "Style:";
            // 
            // dailyRateLabel
            // 
            dailyRateLabel.AutoSize = true;
            dailyRateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dailyRateLabel.Location = new System.Drawing.Point(12, 253);
            dailyRateLabel.Name = "dailyRateLabel";
            dailyRateLabel.Size = new System.Drawing.Size(130, 19);
            dailyRateLabel.TabIndex = 6;
            dailyRateLabel.Text = "Daily Rental Rate:";
            // 
            // fineRateLabel
            // 
            fineRateLabel.AutoSize = true;
            fineRateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fineRateLabel.Location = new System.Drawing.Point(330, 256);
            fineRateLabel.Name = "fineRateLabel";
            fineRateLabel.Size = new System.Drawing.Size(147, 19);
            fineRateLabel.TabIndex = 8;
            fineRateLabel.Text = "Daily Late Fine Rate:";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblItemID.Location = new System.Drawing.Point(392, 108);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new System.Drawing.Size(62, 19);
            lblItemID.TabIndex = 53;
            lblItemID.Text = "Item ID:";
            // 
            // furnitureDescrptionLabel
            // 
            furnitureDescrptionLabel.AutoSize = true;
            furnitureDescrptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            furnitureDescrptionLabel.Location = new System.Drawing.Point(17, 163);
            furnitureDescrptionLabel.Name = "furnitureDescrptionLabel";
            furnitureDescrptionLabel.Size = new System.Drawing.Size(86, 19);
            furnitureDescrptionLabel.TabIndex = 0;
            furnitureDescrptionLabel.Text = "Descrption:";
            // 
            // lblFurnitureID
            // 
            lblFurnitureID.AutoSize = true;
            lblFurnitureID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblFurnitureID.Location = new System.Drawing.Point(17, 116);
            lblFurnitureID.Name = "lblFurnitureID";
            lblFurnitureID.Size = new System.Drawing.Size(95, 19);
            lblFurnitureID.TabIndex = 51;
            lblFurnitureID.Text = "Furniture ID:";
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "Furniture";
            this.furnitureBindingSource.DataSource = this.rentMeDataSet;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FurnitureTableAdapter = this.furnitureTableAdapter;
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
            // furnitureDetailsBindingSource
            // 
            this.furnitureDetailsBindingSource.DataMember = "FurnitureDetails";
            this.furnitureDetailsBindingSource.DataSource = this.rentMeDataSet;
            // 
            // txtFurnitureDescrption
            // 
            this.txtFurnitureDescrption.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "furnitureDescrption", true));
            this.txtFurnitureDescrption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFurnitureDescrption.Location = new System.Drawing.Point(148, 160);
            this.txtFurnitureDescrption.Multiline = true;
            this.txtFurnitureDescrption.Name = "txtFurnitureDescrption";
            this.txtFurnitureDescrption.Size = new System.Drawing.Size(431, 70);
            this.txtFurnitureDescrption.TabIndex = 1;
            // 
            // txtCategory
            // 
            this.txtCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "category", true));
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(148, 311);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(431, 39);
            this.txtCategory.TabIndex = 3;
            // 
            // txtStyle
            // 
            this.txtStyle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "style", true));
            this.txtStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStyle.Location = new System.Drawing.Point(148, 373);
            this.txtStyle.Multiline = true;
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(431, 42);
            this.txtStyle.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(246, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(256, 471);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(91, 31);
            this.btnRestart.TabIndex = 48;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(18, 471);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(137, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 31);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(494, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(375, 471);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 31);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(171, 61);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(306, 39);
            this.lblFurnitureInfo.TabIndex = 49;
            this.lblFurnitureInfo.Text = "Furniture Information";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // store_itemBindingSource
            // 
            this.store_itemBindingSource.DataMember = "Store_item";
            this.store_itemBindingSource.DataSource = this.rentMeDataSet;
            // 
            // store_itemTableAdapter
            // 
            this.store_itemTableAdapter.ClearBeforeFill = true;
            // 
            // cboItemID
            // 
            this.cboItemID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_itemBindingSource, "itemID", true));
            this.cboItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(458, 105);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(121, 27);
            this.cboItemID.TabIndex = 54;
            // 
            // cboFurnitureID
            // 
            this.cboFurnitureID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "furnitureID", true));
            this.cboFurnitureID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFurnitureID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboFurnitureID.FormattingEnabled = true;
            this.cboFurnitureID.Location = new System.Drawing.Point(148, 111);
            this.cboFurnitureID.Name = "cboFurnitureID";
            this.cboFurnitureID.Size = new System.Drawing.Size(121, 27);
            this.cboFurnitureID.TabIndex = 55;
            // 
            // mtxtDailyRate
            // 
            this.mtxtDailyRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "daily_Rate", true));
            this.mtxtDailyRate.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtxtDailyRate.Location = new System.Drawing.Point(148, 248);
            this.mtxtDailyRate.Mask = "$ 99990.00";
            this.mtxtDailyRate.Name = "mtxtDailyRate";
            this.mtxtDailyRate.Size = new System.Drawing.Size(100, 27);
            this.mtxtDailyRate.TabIndex = 56;
            // 
            // mtxtFineRate
            // 
            this.mtxtFineRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "fine_Rate", true));
            this.mtxtFineRate.Font = new System.Drawing.Font("Calibri", 12F);
            this.mtxtFineRate.Location = new System.Drawing.Point(479, 250);
            this.mtxtFineRate.Mask = "$ 99990.99";
            this.mtxtFineRate.Name = "mtxtFineRate";
            this.mtxtFineRate.Size = new System.Drawing.Size(100, 27);
            this.mtxtFineRate.TabIndex = 57;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // navFurniture
            // 
            this.navFurniture.AddNewItem = this.bindingNavigatorAddNewItem;
            this.navFurniture.CountItem = this.bindingNavigatorCountItem;
            this.navFurniture.DeleteItem = this.bindingNavigatorDeleteItem;
            this.navFurniture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.navFurniture.Location = new System.Drawing.Point(0, 0);
            this.navFurniture.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navFurniture.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navFurniture.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navFurniture.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navFurniture.Name = "navFurniture";
            this.navFurniture.PositionItem = this.bindingNavigatorPositionItem;
            this.navFurniture.Size = new System.Drawing.Size(624, 25);
            this.navFurniture.TabIndex = 58;
            this.navFurniture.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FurnitureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 531);
            this.Controls.Add(this.navFurniture);
            this.Controls.Add(this.mtxtFineRate);
            this.Controls.Add(this.mtxtDailyRate);
            this.Controls.Add(this.cboFurnitureID);
            this.Controls.Add(lblItemID);
            this.Controls.Add(this.cboItemID);
            this.Controls.Add(lblFurnitureID);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(furnitureDescrptionLabel);
            this.Controls.Add(this.txtFurnitureDescrption);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(styleLabel);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(dailyRateLabel);
            this.Controls.Add(fineRateLabel);
            this.Name = "FurnitureView";
            this.Text = "SearchFurnitureView";
            this.Load += new System.EventHandler(this.SearchFurnitureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navFurniture)).EndInit();
            this.navFurniture.ResumeLayout(false);
            this.navFurniture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private RentMeDataSetTableAdapters.FurnitureTableAdapter furnitureTableAdapter;
        private RentMeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource furnitureDetailsBindingSource;
        private System.Windows.Forms.TextBox txtFurnitureDescrption;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.BindingSource store_itemBindingSource;
        private RentMeDataSetTableAdapters.Store_itemTableAdapter store_itemTableAdapter;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.ComboBox cboFurnitureID;
        private System.Windows.Forms.MaskedTextBox mtxtDailyRate;
        private System.Windows.Forms.MaskedTextBox mtxtFineRate;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.BindingNavigator navFurniture;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}