using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    public partial class seach_customer : Form
    {
        DataSet dataSet,dataSetEmployee;
        public seach_customer()
        {
            InitializeComponent();
        }
        public seach_customer(DataSet ds)
        {
            dataSetEmployee = ds;
            InitializeComponent();
        }
        private void Lbl_searchByPhone_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_byName_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (by_phone.Text == "")
                {
                    dataSet = new DB_Access().searchCustomer(by_name.Text);
                    Out_customer.Text = dataSet.Tables[0].Rows[0][1] + " " + dataSet.Tables[0].Rows[0][2];
                    Out_customer.Visible = true;
                }
                else
                {
                    dataSet  = new DB_Access().searchCustomer(by_phone.Text);
                    Out_customer.Text = dataSet.Tables[0].Rows[0][1] + " " + dataSet.Tables[0].Rows[0][2];
                    Out_customer.Visible = true;

                }
                GO_button.Visible = true;
                Edit_button.Visible = true;
                btnReturn.Visible = true;
            }
            catch (Exception eex)
            {

            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmNewCustomer(dataSet).Visible = true;
        }

        private void Out_customer_Click(object sender, EventArgs e)
        {
            
        }

        private void GO_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmSelectFurniture(dataSet, dataSetEmployee).Visible = true;

        }

        private void Txt_byPhone(object sender, EventArgs e)
        {

        }

        private void Txt_byName(object sender, EventArgs e)
        {

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmNewCustomer(1).Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Furniture().Visible = true;

        }

        private void btnReturnFurniture_Click(object sender, EventArgs e)

        {
            
            this.Visible = false;
            new frmReturnFurniture(dataSet).Visible = true;

        }
    }
}
