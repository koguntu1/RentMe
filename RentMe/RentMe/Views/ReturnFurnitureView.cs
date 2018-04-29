using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Models;
using RentMe.Controller;

namespace RentMe.Views
{
    public partial class ReturnFurnitureView : Form
    {
        List<ReturnTransaction> returnTransaction;
        ReturnController returnController;
        ItemReturnView returnForm;
        string userID;
        decimal amountOwed;
        decimal amountFined;
        public ReturnFurnitureView(List<ReturnTransaction> transactionReturn, string login, ItemReturnView returnParent)
        {
            InitializeComponent();
            returnTransaction = transactionReturn;
            returnController = new ReturnController();
            userID = login;
            this.returnForm = returnParent;
        }

        private void DisplayReturn(List<ReturnTransaction> listReturnTransaction)
        {

            int i = 0;
            txtFname.Text = listReturnTransaction[i].fname.ToString();
            txtLname.Text = listReturnTransaction[i].lname.ToString();
            BindingList<ReturnTransaction> bindingReturnList = new BindingList<ReturnTransaction>(listReturnTransaction);
            dataGridItemsToReturn.DataSource = bindingReturnList;
            dataGridItemsToReturn.AutoGenerateColumns = true;
            dataGridItemsToReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridItemsToReturn.Columns["description"].HeaderText = "Description";
            dataGridItemsToReturn.Columns["furnitureID"].HeaderText = "Furniture ID";
            dataGridItemsToReturn.Columns["itemID"].HeaderText = "Item ID";
            dataGridItemsToReturn.Columns["Style"].HeaderText = "Style";
            dataGridItemsToReturn.Columns["Category"].HeaderText = "Category";
            dataGridItemsToReturn.Columns["rental_date"].HeaderText = "Rental Date";
            dataGridItemsToReturn.Columns["expected_return"].HeaderText = "Due Date";
            dataGridItemsToReturn.Columns["daily_Rate"].HeaderText = "Daily Rate";
            dataGridItemsToReturn.Columns["daily_Rate"].DefaultCellStyle.Format = "c";
            dataGridItemsToReturn.Columns["amount"].HeaderText = "Amount Due";
            dataGridItemsToReturn.Columns["amount"].DefaultCellStyle.Format = "c";
            dataGridItemsToReturn.Columns["fine_Rate"].HeaderText = "Late Fee";
            dataGridItemsToReturn.Columns["fine_Rate"].DefaultCellStyle.Format = "c";
            dataGridItemsToReturn.Columns["fines"].HeaderText = "Amount Fined";
            dataGridItemsToReturn.Columns["fines"].DefaultCellStyle.Format = "c";
            dataGridItemsToReturn.Columns["fname"].Visible = false;
            dataGridItemsToReturn.Columns["lname"].Visible = false;
            dataGridItemsToReturn.Columns["returnTransactionID"].Visible = false;
            dataGridItemsToReturn.Columns["transaction_date"].Visible = false;
            dataGridItemsToReturn.Columns["comment"].Visible = false;
            dataGridItemsToReturn.Columns["return_date"].Visible = false;
            dataGridItemsToReturn.Columns["employeeID"].Visible = false;
            dataGridItemsToReturn.Columns["memberID"].Visible = false;
            dataGridItemsToReturn.Columns["transactionID"].Visible = false;
            dataGridItemsToReturn.Columns["rentalID"].Visible = false;

        }

        private void ReturnFurnitureView_Load(object sender, EventArgs e)
        {
            DisplayReturn(returnTransaction);
            btnSubmit.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool success = false;
            string name = "";
            int employeeID = returnController.GetEmployeeID(userID);
            int transactionID = returnController.ReturnFurnitureTransaction(Convert.ToDateTime(dateTimePicker1.Value.ToString()), amountOwed, txtComments.Text, employeeID, amountFined); ;
            foreach (var transaction in returnTransaction)
            {
                if (returnController.ReturnFurniture(transaction.rentalID, Convert.ToDateTime(dateTimePicker1.Value.ToString())))
                { 
                    success = returnController.RentalReturnTransaction(transactionID, transaction.rentalID);
                    name = transaction.fname + " " + transaction.lname;
                }
            }
            if (success)
            {
                MessageBox.Show("Transaction completed for " + name + " for " + txtTotalOwed.Text);
                this.returnForm.Close();
                returnForm = new ItemReturnView();
                returnForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Unable to update this transaction.");
                this.Close();
            }
        }

        private void btnCalculateOwed_Click(object sender, EventArgs e)
        {
            amountOwed = 0;
            amountFined = 0;
            foreach (var transaction in returnTransaction)
            {
                decimal amount = (Decimal.Multiply(transaction.daily_Rate, Convert.ToDecimal((Convert.ToDateTime(dateTimePicker1.Value.ToString()) - transaction.rental_date).TotalDays)));
                transaction.amount = amount - (Decimal.Multiply(amount, Convert.ToDecimal(0.20)));
                transaction.fines = (Decimal.Multiply(transaction.fine_Rate, Convert.ToDecimal((Convert.ToDateTime(dateTimePicker1.Value.ToString()) - transaction.expected_return).TotalDays)));
                amountOwed = amountOwed + transaction.amount;
                amountFined = amountFined + transaction.fines;
                if (amountFined <= 0)
                {
                    amountFined = 0;
                }
            }
            txtAmountOwed.Text = amountOwed.ToString("C");
            txtFines.Text = amountFined.ToString("C");
            string totalOwed = (amountOwed + amountFined).ToString("C");
            txtTotalOwed.Text = totalOwed;
            dataGridItemsToReturn.Refresh();
            btnSubmit.Enabled = true;
        }
    }
}
