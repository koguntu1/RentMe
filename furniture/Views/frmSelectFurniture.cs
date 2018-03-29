using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    public partial class frmSelectFurniture : Form
    {
        DataSet DataSetCustomer,DataSet,DataSetEmployee;
        List<string> cart= new List<string>();
        String field,procedure;
        public frmSelectFurniture(DataSet DS,DataSet DataSetEmployee)
        {
            DataSetCustomer = DS;
            this.DataSetEmployee = DataSetEmployee;
            InitializeComponent();
        }

        private void grid_ShowItem_CellContentClick(object senDataSetEmployeer, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object senDataSetEmployeer, EventArgs e)
        {
    


        }

        private void Lbl_foundItems_Click(object senDataSetEmployeer, EventArgs e)
        {

        }

        private void sortby(object senDataSetEmployeer, EventArgs e)
        {
            Cobox_selectItem.Items.Clear();
            DataSet DataSet = null;
            if (Cobox_sortby.Text == "By Item Number")
            {
                DataSet = new DB_Access().furnitureTypes("item_num");
                field = "item_num";
                procedure = "FurnitureByItem";
            }
            else if (Cobox_sortby.Text == "By Category")
            {
                DataSet = new DB_Access().furnitureTypes("category");
                field = "category";
                procedure = "FurnitureByCategory";
            }
            else if (Cobox_sortby.Text == "By Style")
            {
                DataSet = new DB_Access().furnitureTypes("Style");
                field = "Style";
                procedure = "FurnitureByStyle";
            }
            else if (Cobox_sortby.Text == "By Furniture ID")
            {
                DataSet = new DB_Access().furnitureTypes("F_id");
                field = "F_id";
                procedure = "FurnitureByFid";
            }
            if (DataSet != null) {
                foreach (DataRow row in DataSet.Tables[0].Rows)
                {
                    Cobox_selectItem.Items.Add(row[0].ToString());
                }
                
            }
        }

        private void btnProceed_Click(object senDataSetEmployeer, EventArgs e)
        {
            if (cart.Count!=0)
            {
                this.Visible = false;
                new frmRentFurniture(DataSetEmployee, DataSetCustomer, cart).Visible = true;
            }
            else
            {
                this.Visible = true;
                MessageBox.Show("Cart is empty !");
            }
        }

        private void grid_ShowItem_CellClick(object senDataSetEmployeer, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object senDataSetEmployeer, EventArgs e)
        {
            this.Visible = false;
            new seach_customer(DataSetEmployee).Visible = true;
        }

        private void grid_ShowItem_CellMouseClick(object senDataSetEmployeer, DataGridViewCellMouseEventArgs e)
        {

            
           
              
        }

        private void btnAddToCart_Click(object senDataSetEmployeer, EventArgs e)

        {
            for (int i = 0; i < grid_ShowItem.SelectedRows.Count; i++)
            {
                cart.Add(grid_ShowItem.SelectedRows[i].Cells[0].Value.ToString());
            }
            if (cart.Count == 0)
            {
                MessageBox.Show("No item selected !");
            }
            else
            {
              
                MessageBox.Show("Item successfully added to cart");
            }
        }

        private void selectItems(object senDataSetEmployeer, EventArgs e)
        {
            DataSet = new DB_Access().Searchfurniture(field,Cobox_selectItem.Text,procedure);
            grid_ShowItem.DataSource = DataSet.Tables[0].DefaultView;
        }
    }
}
