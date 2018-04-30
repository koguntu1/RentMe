using RentMe.Controller;
using RentMe.Models;
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
    public partial class RentFurnitureForm : Form
    {

        private Member member;
        private Login login;
        private RentalItem rentalItem;
        private Furniture furniture;
        private LoginController lgnController;
        private Employee employee;
        private EmployeeController empController;
        private MemberController memController;
        private RentalTransaction rentalTransaction;
        private RentalItemController rentalItemController;
        private RentalTransactionController rentalTransactionController;
        private RentalTransactionID rentalTransactionID;
        private RentalTransactionIDController rentalTransactionIDController;
        private MDIView mdiView;
        public RentFurnitureForm(Furniture furnitureSelected)
        {
           
            InitializeComponent();
            furniture = furnitureSelected;
            lgnController = new LoginController();
            memController = new MemberController();
            empController = new EmployeeController();
            rentalItemController = new RentalItemController();
            rentalTransactionController = new RentalTransactionController();
            rentalTransactionIDController = new RentalTransactionIDController();
            mdiView = new MDIView();
        }

        private void GetMemberByName(string firstName, string lastName)
        {
            try
            {
                //member = this.memController.GetMemberByName(firstName, lastName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetMemberByPhone(string phoneNumber)
        {
            try
            {
                //member = this.memController.GetMemberByPhone(phoneNumber);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayMember()
        {
            txtFName.Text = member.fname;
            txtMInitial.Text = member.middleInitial;
            txtLastName.Text = member.lname;
            mtxtHomePhone.Text = member.homePhone;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentFurnitureForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.rentMeDataSet.Member);
            cbID.SelectedIndex = -1;
            btnRent.Enabled = false;
            Form frm = MDIView.ActiveForm;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            ToolStripMenuItem lt = (ToolStripMenuItem)ms.Items["login"];
            String userID = lt.Text;
            login = lgnController.getLoggedInUser(userID);
            employee = empController.GetEmployeeById(login.employeeID);
            txtEmployeeFName.Text = employee.fname;
            txtEmployeeMInitial.Text = employee.middleInitial;
            txtEmployeeLastName.Text = employee.lname;
            mtxtEmployeeHomePhone.Text = employee.homePhone;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
          
            if (dtRentalDate.Text.Equals(""))
            {
                MessageBox.Show("Please enter a rental date.");
                return;
            }

            else if (dtReturnDate.Text.Equals(""))
            {
                MessageBox.Show("Please enter a return date.");
                return;
            }

            else
            {
               

                if (!dtRentalDate.Text.Equals("") && !dtReturnDate.Text.Equals("") && Convert.ToDateTime(dtRentalDate.Text) < Convert.ToDateTime(dtReturnDate.Text))
                {
                    RentalItem rentalItem = this.setRentalItem();
                    RentalTransaction rentalTransaction = this.setTransactionInformation();
                    rentalItem.rentalItemID = rentalItemController.AddRentalItem(rentalItem);
                    rentalTransaction.rentalTransactionID = rentalTransactionController.AddRentalTransaction(rentalTransaction);
                    rentalTransactionID = this.setRentalTransactionID();
                    rentalTransactionID.rentalTransactionID = rentalTransactionIDController.AddRentalTransactionID(rentalTransactionID);
                    MessageBox.Show("Item has been rented. ", "Item Rented.");
                    this.Close();
                }
                else if (!dtRentalDate.Text.Equals("") && !dtReturnDate.Text.Equals("") && Convert.ToDateTime(dtRentalDate.Text) > Convert.ToDateTime(dtRentalDate.Text))
                {
                    MessageBox.Show("Return date cannot be before rental date. ", "Invalid Information.");

                }
                else
                {
                    MessageBox.Show("Please provide a rental and return date. ", "Incomplete Information.");
                }
            }
        }

        private RentalTransaction setTransactionInformation()
        {
            rentalTransaction = new RentalTransaction();
            rentalTransaction.transactionDate = DateTime.Now;
            rentalTransaction.employeeID = employee.employeeID;
            rentalTransaction.amount = Convert.ToDouble(furniture.Daily_Rate) * (Convert.ToDateTime(dtReturnDate.Text) - Convert.ToDateTime(dtRentalDate.Text)).TotalDays;
            return rentalTransaction;
        }

        private RentalItem setRentalItem()
        {
            rentalItem = new RentalItem();
            rentalItem.memberID = member.memberID;
            rentalItem.expectedReturn = Convert.ToDateTime(dtReturnDate.Text);
            rentalItem.itemID = furniture.FurnitureID;
            //rentalItem.returnDate = "";
            rentalItem.rentalDate = Convert.ToDateTime(dtRentalDate.Text);
            return rentalItem;
        }

        private RentalTransactionID setRentalTransactionID()
        {
            rentalTransactionID = new RentalTransactionID();
            rentalTransactionID.rentalID = rentalItem.rentalItemID;
            rentalTransactionID.transactionID = rentalTransaction.rentalTransactionID;
            return rentalTransactionID;
        }


        private void cbID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.member = this.memController.GetMemberByID((int)cbID.SelectedValue);
            txtFName.Text = member.fname;
            txtLastName.Text = member.lname;
            txtMInitial.Text = member.middleInitial;
            mtxtHomePhone.Text = member.homePhone;
            btnRent.Enabled = true;
        }
    }
}