using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    public partial class frmRentFurniture : Form
    {
        DataSet Dataset_customer,Dataset_employee,Dataset_furniture;
        List<String> cart;
        public frmRentFurniture(DataSet Dataset_employee,DataSet DT,List<String> items)
        {
            Dataset_customer = DT;
            this.Dataset_employee = Dataset_employee;
            cart = items;
            InitializeComponent();
            TxtRentDate.Text = DateTime.Now.ToShortDateString();
            TxtEmployee_id.Text = Dataset_employee.Tables[0].Rows[0][0].ToString();
            TxtCustomer_id.Text = Dataset_customer.Tables[0].Rows[0][0].ToString();
            int price = 0;
            foreach (String id in cart)
            {
               price=price+int.Parse(new DB_Access().furniture(id).Tables[0].Rows[0][5].ToString());
                Dataset_furniture = new DB_Access().furniture(id);
                grid_selected_item.Rows.Add(Dataset_furniture.Tables[0].Rows[0][0].ToString(), Dataset_furniture.Tables[0].Rows[0][1].ToString(), Dataset_furniture.Tables[0].Rows[0][2].ToString(), Dataset_furniture.Tables[0].Rows[0][3].ToString(), Dataset_furniture.Tables[0].Rows[0][4].ToString(), Dataset_furniture.Tables[0].Rows[0][5].ToString());
            }
            TxtTotal_price.Text = price.ToString();

        }

        private void textBox2_TextChanged(object senDataset_employeer, EventArgs e)
        {

        }

        private void btnBack_Click(object senDataset_employeer, EventArgs e)
        {
            this.Visible = false;
            new frmSelectFurniture(Dataset_customer,Dataset_employee).Visible = true;
        }
        

        private void LblDateFormat_Click(object senDataset_employeer, EventArgs e)
        {

        }

        private void frmRent_Load(object senDataset_employeer, EventArgs e)
        {

        }

        private void btnPay_Click(object senDataset_employeer, EventArgs e)
        {   
            if (TxtDueDate.Text.Length==0)
            {
                MessageBox.Show("Due Date is empty!");
            }
            else
            {
                foreach (String i in cart)
                {
                    MessageBox.Show("Information successfully added to the database !");
                    new DB_Access().addRental(Dataset_customer.Tables[0].Rows[0][0].ToString(), Dataset_employee.Tables[0].Rows[0][0].ToString(), i, DateTime.Now.ToString(), TxtDueDate.Text, "", new DB_Access().furniture(i).Tables[0].Rows[0][5].ToString());
                   
                }

                this.Visible = false;
                new seach_customer(Dataset_employee).Visible = true;
            }

            
        }
    }
}
