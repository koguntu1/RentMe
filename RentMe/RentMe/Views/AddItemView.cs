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
    public partial class AddItemView : Form
    {
        private List<Furniture> furnitureList;
        public AddItemView()
        {
            InitializeComponent();
            LoadComboBoxes();
            cboFurnitureID.SelectedValue = -1;
        }

        private void LoadComboBoxes()
        {
            try
            {
                furnitureList = FurnitureController.GetFurnitureList();
                cboFurnitureID.DataSource = furnitureList;
                cboFurnitureID.DisplayMember = "Description";
                cboFurnitureID.ValueMember = "FurnitureID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Store_item store_Item = new Store_item();
            store_Item.furnitureID = (int)cboFurnitureID.SelectedValue;
            try
            {
                store_Item.itemID = StoreItemController.AddStoreItem(store_Item);
                MessageBox.Show("Item successfully added.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
