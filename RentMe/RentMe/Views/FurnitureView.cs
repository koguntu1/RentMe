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

namespace RentMe.Views
{
    public partial class FurnitureView : Form
    {

        private FurnitureController inController;
        MenuView menuScreen = new MenuView();
        public FurnitureView()
        {
            InitializeComponent();
        }

        private void furnitureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.furnitureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentMeDataSet);

        }

        private void SearchFurnitureView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Store_item' table. You can move, or remove it, as needed.
            this.store_itemTableAdapter.Fill(this.rentMeDataSet.Store_item);
            DisableControls();
            cboFurnitureID.Enabled = true;
            cboItemID.Enabled = true;
            txtCategory.Enabled = true;
            txtStyle.Enabled = true;
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
            DisableControls();
            btnAdd.Text = "Update";
            // change to true for next iteration
            btnAdd.Enabled = false;
            btnSubmit.Enabled = false;
            // ---------------------
            btnRestart.Enabled = true;
            btnExit.Enabled = true;


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DisableControls();
            cboFurnitureID.Enabled = true;
            cboItemID.Enabled = true;
            txtCategory.Enabled = true;
            txtStyle.Enabled = true;
            btnSearch.Enabled = true;
            btnAdd.Text = "Add";
            //btnAdd.Enabled = true;  Add next iteration
            btnRestart.Enabled = true;
            btnExit.Enabled = true;
        }
    }
}
