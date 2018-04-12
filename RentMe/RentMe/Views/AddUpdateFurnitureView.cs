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
    public partial class AddUpdateFurnitureView : Form
    {
        private bool update = false;
        private Furniture furniture;
        private List<Style> styleList;
        private List<Category> categoryList;

        public AddUpdateFurnitureView(bool isUpdate, Furniture furnitureSelected)
        {
            InitializeComponent();
            update = isUpdate;
            furniture = furnitureSelected;
            LoadComboBoxes();
            if (update)
            {
                this.Text = "Update Furniture";
                fillData();
            }
            else
            {
                this.Text = "Add Furniture";
                cboCategory.SelectedValue = -1;
                cboStyle.SelectedValue = -1;
            }
            
        }

        private void LoadComboBoxes()
        {
            try
            {
                styleList = StyleController.GetStyleList();
                cboStyle.DataSource = styleList;
                cboStyle.DisplayMember = "description";
                cboStyle.ValueMember = "styleID";

                categoryList = CategoryController.GetCategoryList();
                cboCategory.DataSource = categoryList;
                cboCategory.DisplayMember = "description";
                cboCategory.ValueMember = "categoryID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void fillData()
        {
            txtDailyRate.Text = furniture.Daily_Rate.ToString();
            txtDescription.Text = furniture.Description;
            txtFineRate.Text = furniture.Fine_Rate.ToString();
            cboCategory.SelectedValue = furniture.CategoryID;
            cboStyle.SelectedValue = furniture.StyleID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (update && IsValidData())
            {
                Furniture newFurniture = new Furniture();
                newFurniture.FurnitureID = furniture.FurnitureID;
                newFurniture.CategoryID = (int)cboCategory.SelectedValue;
                newFurniture.Category = cboCategory.Text;
                newFurniture.Style = cboStyle.Text;
                newFurniture.StyleID = (int)cboStyle.SelectedValue;
                newFurniture.Description = txtDescription.Text.Trim();
                newFurniture.Daily_Rate = Convert.ToDecimal(txtDailyRate.Text.Trim());
                newFurniture.Fine_Rate = Convert.ToDecimal(txtFineRate.Text.Trim());
                try
                {
                    if( !FurnitureController.UpdateFurniture(furniture,newFurniture))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that furniture.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        furniture = newFurniture;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Furniture has been updated.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else if (!update && IsValidData())
            {
                furniture = new Furniture();
                furniture.CategoryID = (int)cboCategory.SelectedValue;
                furniture.StyleID = (int)cboStyle.SelectedValue;
                furniture.Fine_Rate = Convert.ToDecimal(txtFineRate.Text.Trim());
                furniture.Daily_Rate = Convert.ToDecimal(txtDailyRate.Text.Trim());
                furniture.Description = txtDescription.Text.Trim();
                try
                {
                    furniture.FurnitureID = FurnitureController.AddFurniture(furniture);
                    MessageBox.Show("Furniture successfully added.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
        }


        private bool IsValidData()
        {
            if (Validator.IsPresent(txtFineRate) &&
                        Validator.IsPresent(txtDescription) &&
                        Validator.IsPresent(txtDailyRate) &&
                        Validator.IsPresent(cboCategory) &&
                        Validator.IsPresent(cboStyle) )
            {
                if (Validator.IsDouble(txtFineRate) &&
                        Validator.IsDouble(txtDailyRate) && (int)cboCategory.SelectedValue != -1 &&
                       (int)cboStyle.SelectedValue != -1)
                {
                    return true;

                }
                else
                {
                    MessageBox.Show("All fields must be completed. " +
                      "Please try again.", "Fields not completed.");
                }
            }

            return false;
        }

        private void AddUpdateFurnitureView_Load(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
