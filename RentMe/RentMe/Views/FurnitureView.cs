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
        //MenuView menuScreen = new MenuView();
        public FurnitureView()
        {
            InitializeComponent();
            inController = new FurnitureController();
            furnitureList = null;
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
            //clear data table first
            if (dataGridViewFurniture.Columns.Count > 11)
            {
                dataGridViewFurniture.Columns.RemoveAt(11);
            }
            dataGridViewFurniture.DataSource = null;
            dataGridViewFurniture.Rows.Clear();
            dataGridViewFurniture.Refresh();


            int furnitureID = 0;
            int itemID = 0;
            int categoryID = 0;
            int styleID = 0;
            try
            {
                if (cboFurnitureID.SelectedValue == null && cboItemID.SelectedValue == null && cboCategory.SelectedValue == null && cboStyle.SelectedValue == null) {
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
                        dataGridViewFurniture.DataSource = furnitureList;
                        //hide some columns
                        dataGridViewFurniture.Columns[2].Visible = false;
                        dataGridViewFurniture.Columns[6].Visible = false;
                        dataGridViewFurniture.Columns[9].Visible = false;
                        //add button to data grid
                        DataGridViewButtonColumn SelectButton = new DataGridViewButtonColumn();
                        SelectButton.Name = "";
                        SelectButton.Text = "Edit Detail";
                        SelectButton.UseColumnTextForButtonValue = true;
                        if (dataGridViewFurniture.Columns["Edit Detail"] == null)
                        {
                            dataGridViewFurniture.Columns.Insert(10, SelectButton);
                        }

                        DataGridViewButtonColumn RentFurnitureButton = new DataGridViewButtonColumn();
                        RentFurnitureButton.Name = "";
                        RentFurnitureButton.Text = "Rent Furniture";
                        RentFurnitureButton.UseColumnTextForButtonValue = true;
                        dataGridViewFurniture.Columns.Insert(11, RentFurnitureButton);

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
            if(dataGridViewFurniture.Columns.Count > 11)
            {
                dataGridViewFurniture.Columns.RemoveAt(11);
            }
            dataGridViewFurniture.DataSource = null;
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
                if (e.ColumnIndex == 10)
                {
                    DataGridViewRow row = this.dataGridViewFurniture.Rows[e.RowIndex];
                    Furniture furniture = new Furniture();
                    furniture.Category = row.Cells["Category"].Value.ToString();
                    furniture.StyleID = (int)row.Cells["StyleID"].Value;
                    furniture.Style = row.Cells["Style"].Value.ToString();
                    furniture.Description = row.Cells["Description"].Value.ToString();
                    furniture.CategoryID = (int)row.Cells["CategoryID"].Value;
                    furniture.category = null;
                    furniture.ItemID = (int)row.Cells["ItemID"].Value;
                    furniture.FurnitureID = (int)row.Cells["FurnitureID"].Value;
                    furniture.Fine_Rate = Convert.ToDecimal(row.Cells["Fine_Rate"].Value.ToString());
                    furniture.Daily_Rate = Convert.ToDecimal(row.Cells["Daily_Rate"].Value.ToString());
                    //int invoiceID = (int)row.Cells["InvoiceID"].Value;
                    //frmLineItem frmLineItem = new frmLineItem(invoiceID);
                    //frmLineItem.Show();
                    AddUpdateFurnitureView addUpdateFurnitureView = new AddUpdateFurnitureView(true, furniture);
                    addUpdateFurnitureView.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAddFurniture_Click(object sender, EventArgs e)
        {
            AddUpdateFurnitureView addUpdateFurnitureView = new AddUpdateFurnitureView(false, null);
            addUpdateFurnitureView.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItemView addItemView = new AddItemView();
            addItemView.Show();
        }
    }
}
