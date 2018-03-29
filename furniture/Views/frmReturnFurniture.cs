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
    public partial class frmReturnFurniture : Form

    {
        DataSet Dataset1 = new DataSet();
        string Customer_id;
        int count;
        double Amount = 0;
        double fine = 0;
        double returnAmount = 0;
        double finalAmount;
        public frmReturnFurniture(DataSet dt)
        {
            InitializeComponent();
            customer_name.Text = dt.Tables[0].Rows[0][1].ToString() + dt.Tables[0].Rows[0][2].ToString();
            Customer_id =dt.Tables[0].Rows[0][0].ToString();
        }

        private void frmReturn_Load(object sender, EventArgs e)
        {

        }

        private void lblAmtToReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new seach_customer().Visible = true;
        }

        private void fundRecords_Click(object sender, EventArgs e)
        {
            Dataset1 = new DB_Access().FindRental(Customer_id);
            if (Dataset1.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Account is already cleared!");
            }
            else
            {

                grid_selected_item.DataSource = Dataset1.Tables[0].DefaultView;
                count = Dataset1.Tables[0].Rows.Count;

                for (int i = 0; i < count; i++)
                {
                    Amount = Amount + Int32.Parse(Dataset1.Tables[0].Rows[i][4].ToString());


                }
                finalAmount = Amount;
                AmountBox.Text = Amount.ToString();
                DateTime dueDate;
                DateTime RetrunDate;
                DateTime pDate;
                double peStr_ReturnDateay = 0;


                for (int i = 0; i < count; i++)
                {

                    string Str_dueDate = Dataset1.Tables[0].Rows[i][2].ToString();
                    string Str_ReturnDate = Dataset1.Tables[0].Rows[i][2].ToString();
                    dueDate = DateTime.Parse(Str_dueDate);
                    pDate = DateTime.Parse(Dataset1.Tables[0].Rows[i][1].ToString());
                    peStr_ReturnDateay = peStr_ReturnDateay + (dueDate - pDate).TotalDays;
                    RetrunDate = DateTime.Now;
                    if (dueDate.Date > RetrunDate.Date)
                    {
                        returnAmount = returnAmount + (dueDate - RetrunDate).TotalDays;

                    }
                    else
                    {
                        fine = fine + (RetrunDate - dueDate).TotalDays;
                    }
                }
                if (fine > 0)
                {
                    fine = (fine / count) * ((10.0 / 100.0) * (finalAmount / peStr_ReturnDateay)); //10% fineper day
                }
                if (returnAmount > 0)
                {
                    returnAmount = (returnAmount / count) * ((50.0 / 100.0) * (finalAmount / peStr_ReturnDateay));//return 50% by day
                }
                finalAmount = finalAmount + fine - returnAmount;
                fineT.Text = fine.ToString();
                AmtReturn.Text = returnAmount.ToString();

                TotalAmount.Text = finalAmount.ToString();
            }


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (TotalAmount.Text.Length == 0)
            {
                MessageBox.Show("Nothing to pay. Thank you !");
                this.Visible = false;
                new seach_customer().Visible = true;
            }
            else
            {
                new DB_Access().DeleteRental(Customer_id);
                MessageBox.Show("Account has been cleared. Thank you !");
                this.Visible = false;
                new seach_customer().Visible = true;
            }
           
        }
    }
}
