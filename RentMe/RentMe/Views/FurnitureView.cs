using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.Views
{
    public partial class FurnitureView : Form
    {

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
            // TODO: This line of code loads data into the 'rentMeDataSet.FurnitureDetails' table. You can move, or remove it, as needed.
            this.furnitureDetailsTableAdapter.Fill(this.rentMeDataSet.FurnitureDetails);
            // TODO: This line of code loads data into the 'rentMeDataSet.Furniture' table. You can move, or remove it, as needed.
            this.furnitureTableAdapter.Fill(this.rentMeDataSet.Furniture);
            DisableControls();
            cboFurnitureID.Enabled = true;
            cboItemID.Enabled = true;
            txtCategory.Enabled = true;
            txtStyle.Enabled = true;
            btnSearch.Enabled = true;
            btnRestart.Enabled = true;
            btnExit.Enabled = true;

        }

        private void FurnitureView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                return;
            }
            else
            {
                if (menuScreen.Enabled)
                {

                    if (menuScreen.IsDisposed)
                    {
                        menuScreen = new MenuView();
                        menuScreen.StartPosition = FormStartPosition.CenterScreen;
                        menuScreen.Show();
                    }
                    else
                    {
                        menuScreen.StartPosition = FormStartPosition.CenterScreen;
                        menuScreen.Show();
                    }
                }
            }
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
            if (menuScreen.Enabled)
            {

                if (menuScreen.IsDisposed)
                {
                    menuScreen = new MenuView();
                    menuScreen.StartPosition = FormStartPosition.CenterScreen;
                    menuScreen.Show();
                }
                else
                {
                    menuScreen.StartPosition = FormStartPosition.CenterScreen;
                    menuScreen.Show();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisableControls();
            btnAdd.Text = "Update";
            btnAdd.Enabled = false;
            btnSubmit.Enabled = false;
            btnRestart.Enabled = true;
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
            btnRestart.Enabled = true;
            btnExit.Enabled = true;
        }
    }
}
