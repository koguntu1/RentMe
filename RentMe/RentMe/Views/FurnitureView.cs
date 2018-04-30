using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Models;

namespace RentMe.Views
{
    public partial class FurnitureView : Form
    {

        private FurnitureController inController;
        List<Furniture> furnitureList;
        AddUpdateFurnitureView addUpdateFurnitureView;
        AddItemView addItemView;
        //MenuView menuScreen = new MenuView();
        public FurnitureView()
        {
            InitializeComponent();
            inController = new FurnitureController();
            furnitureList = null;
            addUpdateFurnitureView = new AddUpdateFurnitureView(false, null, this);
            addItemView = new AddItemView();
        }

        private void SearchFurnitureView_Load(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Fill(this.rentMeDataSet.Category);
            this.styleTableAdapter.Fill(this.rentMeDataSet.Style);
            this.store_itemTableAdapter.Fill(this.rentMeDataSet.Store_item);
            this.furnitureTableAdapter.Fill(this.rentMeDataSet.Furniture);
            DisableControls();
            cboFurnitureID.Enabled = true;
            cboFurnitureID.SelectedIndex = -1;
            cboItemID.Enabled = true;
            cboItemID.SelectedIndex = -1;
            cboStyle.Enabled = true;
            cboStyle.SelectedIndex = -1;
            cboCategory.Enabled = true;
            cboCategory.SelectedIndex = -1;
            btnSearch.Text = "Search";
            btnSearch.Enabled = true;
            btnRestart.Enabled = false;
            btnAddItem.Enabled = true;
            btnAddFurniture.Enabled = true;
            btnExit.Enabled = true;

        }

        private void EnableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = true;
                }

                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = true;
                }

                if (ctrl is BindingNavigator)
                {
                    ((BindingNavigator)ctrl).Enabled = true;
                }
            }
        }

        private void DisableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = false;
                }

                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = false;
                }

                if (ctrl is BindingNavigator)
                {
                    ((BindingNavigator)ctrl).Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        public void refreshData()
        {
            //clear data table first
            //if (dataGridViewFurniture.Columns.Count >= 11)
            //{
            //    dataGridViewFurniture.Columns.RemoveAt(10);
            //}
            dataGridViewFurniture.DataSource = null;
            dataGridViewFurniture.Rows.Clear();
            dataGridViewFurniture.Refresh();


            int furnitureID = 0;
            int itemID = 0;
            int categoryID = 0;
            int styleID = 0;
            try
            {
                if (cboFurnitureID.SelectedValue == null && cboItemID.SelectedValue == null && cboCategory.SelectedValue == null && cboStyle.SelectedValue == null)
                {
                    MessageBox.Show("At least one box must be selected.");
                }
                else
                {
                    furnitureID = Convert.ToInt32(cboFurnitureID.SelectedValue);
                    itemID = Convert.ToInt32(cboItemID.SelectedValue);
                    categoryID = Convert.ToInt32(cboCategory.SelectedValue);
                    styleID = Convert.ToInt32(cboStyle.SelectedValue);
                    furnitureList = this.inController.GetFurniture(furnitureID, itemID, categoryID, styleID);
                    if (furnitureList.Count > 0)
                    {
                        //Furniture furniture;
                        //for (int i = 0; i < furnitureList.Count; i++)
                        //{
                        //    furniture = furnitureList[i];
                        //    lvFurniture.Items.Add(furniture.FurnitureID.ToString());
                        //    lvFurniture.Items[i].SubItems.Add(furniture.Description.ToString());
                        //    lvFurniture.Items[i].SubItems.Add(furniture.ItemID.ToString());
                        //    lvFurniture.Items[i].SubItems.Add(furniture.Style.ToString());
                        //    lvFurniture.Items[i].SubItems.Add(furniture.Category.ToString());
                        //    lvFurniture.Items[i].SubItems.Add(furniture.Daily_Rate.ToString());
                        //    lvFurniture.Items[i].SubItems.Add(furniture.Fine_Rate.ToString());
                        //}
                        //lvFurniture.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        DisableControls();
                        btnSearch.Text = "Refresh";
                        btnSearch.Enabled = true;
                        // change to true for next iteration
                        btnAddFurniture.Enabled = true;
                        btnAddItem.Enabled = true;
                        // ---------------------
                        btnRestart.Enabled = true;
                        btnExit.Enabled = true;

                        //begin for grid data
                        dataGridViewFurniture.AutoGenerateColumns = true;
                        dataGridViewFurniture.AutoResizeColumns();// = true;
                        dataGridViewFurniture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridViewFurniture.DataSource = furnitureList;
                        //hide some columns
                        //dataGridViewFurniture.Columns["FurnitureID"].Visible = false;
                        dataGridViewFurniture.Columns["StyleID"].Visible = false;
                        //dataGridViewFurniture.Columns["ItemID"].Visible = false;
                        dataGridViewFurniture.Columns["CategoryID"].Visible = false;
                        dataGridViewFurniture.Columns["FurnitureID"].HeaderText = "Furniture ID";
                        dataGridViewFurniture.Columns["ItemID"].HeaderText = "Item ID";
                        dataGridViewFurniture.Columns["Description"].HeaderText = "Description";
                        dataGridViewFurniture.Columns["StyleID"].HeaderText = "Style ID";
                        dataGridViewFurniture.Columns["Style"].HeaderText = "Style";
                        dataGridViewFurniture.Columns["Category"].HeaderText = "Category";
                        dataGridViewFurniture.Columns["CategoryID"].HeaderText = "Category ID";
                        dataGridViewFurniture.Columns["Fine_Rate"].HeaderText = "Fine Rate";
                        dataGridViewFurniture.Columns["Daily_Rate"].HeaderText = "Daily Rate";

                        //add button to data grid
                        DataGridViewButtonColumn SelectButton = new DataGridViewButtonColumn();
                        SelectButton.Name = "editDetail";
                        SelectButton.Text = "Edit Detail";
                        SelectButton.HeaderText = "Edit Detail";
                        SelectButton.UseColumnTextForButtonValue = true;
                        if (dataGridViewFurniture.Columns["editDetail"] == null)
                        {
                            dataGridViewFurniture.Columns.Insert(0, SelectButton);
                        }
                        DataGridViewButtonColumn RentFurnitureButton = new DataGridViewButtonColumn();
                        RentFurnitureButton.Name = "rentFurniture";
                        RentFurnitureButton.Text = "Rent Furniture";
                        RentFurnitureButton.HeaderText = "Rent Furniture";
                        RentFurnitureButton.UseColumnTextForButtonValue = true;
                        if (dataGridViewFurniture.Columns["rentFurniture"] == null)
                        {
                            dataGridViewFurniture.Columns.Insert(1, RentFurnitureButton);
                        }
                        dataGridViewFurniture.Rows[0].ReadOnly = true;
                        dataGridViewFurniture.Columns["editDetail"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dataGridViewFurniture.Columns["rentFurniture"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        int i = 0;
                        foreach (DataGridViewColumn c in dataGridViewFurniture.Columns)
                        {
                            i += c.Width;
                        }
                        dataGridViewFurniture.Width = i + dataGridViewFurniture.RowHeadersWidth + 2;
                        dataGridViewFurniture.Focus();
                        dataGridViewFurniture.CurrentCell = dataGridViewFurniture.Rows[0].Cells[0];
                        this.CenterToScreen();

                        //end for grid data


                    }
                    else
                    {
                        MessageBox.Show("No furniture to show. Please try your search again.");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        { 
            DisableControls();
            cboFurnitureID.Enabled = true;
            cboFurnitureID.SelectedIndex = -1;
            cboItemID.Enabled = true;
            cboItemID.SelectedIndex = -1;
            cboStyle.Enabled = true;
            cboStyle.SelectedIndex = -1;
            cboCategory.Enabled = true;
            cboCategory.SelectedIndex = -1;
            dataGridViewFurniture.DataSource = null;
            dataGridViewFurniture.Columns.Clear();
            dataGridViewFurniture.Rows.Clear();
            dataGridViewFurniture.Refresh();
            btnSearch.Enabled = true;
            btnSearch.Text = "Search";
            btnAddFurniture.Enabled = true;
            btnAddItem.Enabled = true;
           
            btnRestart.Enabled = true;
            btnExit.Enabled = true;
        }

        private void dataGridViewFurniture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = this.dataGridViewFurniture.Rows[e.RowIndex];
                    Furniture furniture = new Furniture();
                    furniture.Category = row.Cells["Category"].Value.ToString();
                    furniture.StyleID = (int)row.Cells["StyleID"].Value;
                    furniture.Style = row.Cells["Style"].Value.ToString();
                    furniture.Description = row.Cells["Description"].Value.ToString();
                    furniture.CategoryID = (int)row.Cells["CategoryID"].Value;
                    //furniture.category = null;
                    furniture.ItemID = (int)row.Cells["ItemID"].Value;
                    furniture.FurnitureID = (int)row.Cells["FurnitureID"].Value;
                    furniture.Fine_Rate = Convert.ToDecimal(row.Cells["Fine_Rate"].Value.ToString());
                    furniture.Daily_Rate = Convert.ToDecimal(row.Cells["Daily_Rate"].Value.ToString());
                    //int invoiceID = (int)row.Cells["InvoiceID"].Value;
                    //frmLineItem frmLineItem = new frmLineItem(invoiceID);
                    //frmLineItem.Show();

                    AddUpdateFurnitureView addUpdateFurnitureView = new AddUpdateFurnitureView(true, furniture, this);
                    addUpdateFurnitureView.MdiParent = this.MdiParent;
                    addUpdateFurnitureView.StartPosition = FormStartPosition.CenterParent;
                    addUpdateFurnitureView.Show();
                }
                if (e.ColumnIndex == 1)
                {
                    Furniture furniture = new Furniture();
                    DataGridViewRow row = this.dataGridViewFurniture.Rows[e.RowIndex];
                    furniture.Category = row.Cells["Category"].Value.ToString();
                    furniture.StyleID = (int)row.Cells["StyleID"].Value;
                    furniture.Style = row.Cells["Style"].Value.ToString();
                    furniture.Description = row.Cells["Description"].Value.ToString();
                    furniture.CategoryID = (int)row.Cells["CategoryID"].Value;
                    //furniture.category = null;
                    furniture.ItemID = (int)row.Cells["ItemID"].Value;
                    furniture.FurnitureID = (int)row.Cells["FurnitureID"].Value;
                    furniture.Fine_Rate = Convert.ToDecimal(row.Cells["Fine_Rate"].Value.ToString());
                    furniture.Daily_Rate = Convert.ToDecimal(row.Cells["Daily_Rate"].Value.ToString());
                    RentFurnitureForm rentFurnitureForm = new RentFurnitureForm(furniture);
                    rentFurnitureForm.MdiParent = this.MdiParent;
                    rentFurnitureForm.StartPosition = FormStartPosition.CenterParent;
                    rentFurnitureForm.Show();
                }
            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException || ex is ArgumentOutOfRangeException)
                {

                }
                else
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnAddFurniture_Click(object sender, EventArgs e)
        {
            //AddUpdateFurnitureView addUpdateFurnitureView = new AddUpdateFurnitureView(false, null, this);
            ////addUpdateFurnitureView.MdiParent = this;
            //addUpdateFurnitureView.StartPosition = FormStartPosition.CenterParent;
            //addUpdateFurnitureView.Show();

            if (addUpdateFurnitureView.Enabled)
            {


                if (addUpdateFurnitureView.IsDisposed)
                {
                    addUpdateFurnitureView = new AddUpdateFurnitureView(false, null, this);
                    addUpdateFurnitureView.MdiParent = this.MdiParent;
                    addUpdateFurnitureView.StartPosition = FormStartPosition.CenterScreen;
                    addUpdateFurnitureView.Show();
                }
                else
                {
                    addUpdateFurnitureView.MdiParent = this.MdiParent;
                    addUpdateFurnitureView.StartPosition = FormStartPosition.CenterScreen;
                    addUpdateFurnitureView.Show();

                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (addItemView.Enabled)
            {


                if (addItemView.IsDisposed)
                {
                    addItemView = new AddItemView();
                    addItemView.MdiParent = this.MdiParent;
                    addItemView.StartPosition = FormStartPosition.CenterScreen;
                    addItemView.Show();
                }
                else
                {
                    addItemView.MdiParent = this.MdiParent;
                    addItemView.StartPosition = FormStartPosition.CenterScreen;
                    addItemView.Show();

                }
            }
        }
    }
}
