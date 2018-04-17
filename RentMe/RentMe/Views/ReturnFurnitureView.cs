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
        ReturnTransaction returnTransaction;
        ReturnController returnController;
        string userID;
        decimal amountOwed;
        decimal amountFined;
        public ReturnFurnitureView(ReturnTransaction transactionReturn, string login)
        {
            InitializeComponent();
            returnTransaction = transactionReturn;
            returnController = new ReturnController();
            userID = login;
        }

        private void DisplayReturn(ReturnTransaction returnTransaction)
        {
            txtFname.Text = returnTransaction.fname.ToString();
            txtLname.Text = returnTransaction.lname.ToString();
            txtDescription.Text = returnTransaction.description.ToString();
            txtCategory.Text = returnTransaction.category.ToString();
            txtStyle.Text = returnTransaction.style.ToString();
            dtRented.Text = returnTransaction.rental_date.ToString();
            dtExpectedReturn.Text = returnTransaction.expected_return.ToString();
            amountOwed = Decimal.Multiply(returnTransaction.daily_Rate, Convert.ToDecimal((DateTime.Now - returnTransaction.rental_date).TotalDays)) - returnTransaction.amount;
            amountFined = 0;
            if (DateTime.Now > returnTransaction.expected_return)
            {
                amountFined = Decimal.Multiply(returnTransaction.fine_Rate, Convert.ToDecimal((DateTime.Now - returnTransaction.expected_return).TotalDays));
            }
            txtAmountOwed.Text = amountOwed.ToString("C");

            txtFines.Text = amountFined.ToString("C");
            string totalOwed = (amountOwed + amountFined).ToString("C");
            txtTotalOwed.Text = totalOwed;
        }

        private void ReturnFurnitureView_Load(object sender, EventArgs e)
        {
            DisplayReturn(returnTransaction);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(returnController.ReturnFurniture(returnTransaction.rentalID))
            {
                int employeeID = returnController.GetEmployeeID(userID);
                int transactionID = returnController.ReturnFurnitureTransaction(DateTime.Now, amountOwed, txtComments.Text, employeeID, amountFined);
                bool success = returnController.RentalReturnTransaction(transactionID, returnTransaction.rentalID);
                if (success)
                {
                    MessageBox.Show("Transaction completed for " + returnTransaction.fname + " " + returnTransaction.lname + ". for " + txtTotalOwed.Text);
                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("Unable to update this transaction.");
                this.Close();
            }

        }
    }
}
