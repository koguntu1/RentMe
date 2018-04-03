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
        MenuView menuScreen = new MenuView();
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
            btnSearch.Enabled = true;
            btnRestart.Enabled = true;
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
                        Furniture furniture;
                        for (int i = 0; i < furnitureList.Count; i++)
                        {
                            furniture = furnitureList[i];
                            lvFurniture.Items.Add(furniture.furnitureID.ToString());
                            lvFurniture.Items[i].SubItems.Add(furniture.description.ToString());
                            lvFurniture.Items[i].SubItems.Add(furniture.itemID.ToString());
                            lvFurniture.Items[i].SubItems.Add(furniture.style.ToString());
                            lvFurniture.Items[i].SubItems.Add(furniture.category.ToString());
                            lvFurniture.Items[i].SubItems.Add(furniture.daily_Rate.ToString());
                            lvFurniture.Items[i].SubItems.Add(furniture.fine_Rate.ToString());
                        }
                        lvFurniture.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        DisableControls();
                        btnAdd.Text = "Update";
                        // change to true for next iteration
                        btnAdd.Enabled = false;
                        btnSubmit.Enabled = false;
                        // ---------------------
                        btnRestart.Enabled = true;
                        btnExit.Enabled = true;
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
            lvFurniture.Items.Clear();
            btnSearch.Enabled = true;
            btnAdd.Text = "Add";
            //btnAdd.Enabled = true;  Add next iteration
            btnRestart.Enabled = true;
            btnExit.Enabled = true;
        }
    }
}
