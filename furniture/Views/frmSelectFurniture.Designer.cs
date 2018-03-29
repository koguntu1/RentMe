namespace furniture
{
    partial class frmSelectFurniture
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
            this.Cobox_sortby = new System.Windows.Forms.ComboBox();
            this.Cobox_selectItem = new System.Windows.Forms.ComboBox();
            this.Lbl_searchFurniture = new System.Windows.Forms.Label();
            this.Lbl_type = new System.Windows.Forms.Label();
            this.grid_ShowItem = new System.Windows.Forms.DataGridView();
            this.Lbl_foundItems = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShowItem)).BeginInit();
            this.SuspendLayout();
            // 
            // Cobox_sortby
            // 
            this.Cobox_sortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cobox_sortby.FormattingEnabled = true;
            this.Cobox_sortby.Items.AddRange(new object[] {
            "By Item Number",
            "By Category",
            "By Style",
            "By Furniture ID"});
            this.Cobox_sortby.Location = new System.Drawing.Point(133, 105);
            this.Cobox_sortby.Name = "Cobox_sortby";
            this.Cobox_sortby.Size = new System.Drawing.Size(128, 21);
            this.Cobox_sortby.TabIndex = 0;
            this.Cobox_sortby.SelectedIndexChanged += new System.EventHandler(this.sortby);
            // 
            // Cobox_selectItem
            // 
            this.Cobox_selectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cobox_selectItem.FormattingEnabled = true;
            this.Cobox_selectItem.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Cobox_selectItem.Location = new System.Drawing.Point(376, 97);
            this.Cobox_selectItem.Name = "Cobox_selectItem";
            this.Cobox_selectItem.Size = new System.Drawing.Size(121, 21);
            this.Cobox_selectItem.TabIndex = 1;
            this.Cobox_selectItem.SelectedIndexChanged += new System.EventHandler(this.selectItems);
            // s
            // Lbl_searchFurniture
            // 
            this.Lbl_searchFurniture.AutoSize = true;
            this.Lbl_searchFurniture.Location = new System.Drawing.Point(39, 105);
            this.Lbl_searchFurniture.Name = "Lbl_searchFurniture";
            this.Lbl_searchFurniture.Size = new System.Drawing.Size(88, 13);
            this.Lbl_searchFurniture.TabIndex = 2;
            this.Lbl_searchFurniture.Text = "Search furniture :";
            // 
            // Lbl_type
            // 
            this.Lbl_type.AutoSize = true;
            this.Lbl_type.Location = new System.Drawing.Point(311, 105);
            this.Lbl_type.Name = "Lbl_type";
            this.Lbl_type.Size = new System.Drawing.Size(45, 13);
            this.Lbl_type.TabIndex = 3;
            this.Lbl_type.Text = "Types : ";
            // 
            // grid_ShowItem
            // 
            this.grid_ShowItem.AllowUserToAddRows = false;
            this.grid_ShowItem.AllowUserToDeleteRows = false;
            this.grid_ShowItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ShowItem.Location = new System.Drawing.Point(133, 184);
            this.grid_ShowItem.Name = "grid_ShowItem";
            this.grid_ShowItem.ReadOnly = true;
            this.grid_ShowItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ShowItem.Size = new System.Drawing.Size(551, 171);
            this.grid_ShowItem.TabIndex = 4;
            this.grid_ShowItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ShowItem_CellClick);
            this.grid_ShowItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ShowItem_CellContentClick);
            this.grid_ShowItem.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_ShowItem_CellMouseClick);
            // 
            // Lbl_foundItems
            // 
            this.Lbl_foundItems.AutoSize = true;
            this.Lbl_foundItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_foundItems.Location = new System.Drawing.Point(112, 147);
            this.Lbl_foundItems.Name = "Lbl_foundItems";
            this.Lbl_foundItems.Size = new System.Drawing.Size(73, 13);
            this.Lbl_foundItems.TabIndex = 5;
            this.Lbl_foundItems.Text = "Found items...";
            this.Lbl_foundItems.Click += new System.EventHandler(this.Lbl_foundItems_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(666, 413);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 6;
            this.btnProceed.Text = "Proceed ";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(133, 387);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "AddToCart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<<-Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 468);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.Lbl_foundItems);
            this.Controls.Add(this.grid_ShowItem);
            this.Controls.Add(this.Lbl_type);
            this.Controls.Add(this.Lbl_searchFurniture);
            this.Controls.Add(this.Cobox_selectItem);
            this.Controls.Add(this.Cobox_sortby);
            this.Name = "Form5";
            this.Text = "Search Furniture: ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShowItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cobox_sortby;
        private System.Windows.Forms.ComboBox Cobox_selectItem;
        private System.Windows.Forms.Label Lbl_searchFurniture;
        private System.Windows.Forms.Label Lbl_type;
        private System.Windows.Forms.DataGridView grid_ShowItem;
        private System.Windows.Forms.Label Lbl_foundItems;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnBack;
    }
}