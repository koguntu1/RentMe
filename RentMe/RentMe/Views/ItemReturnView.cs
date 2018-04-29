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
    public partial class ItemReturnView : Form
    {
        ReturnTransaction returnTransaction;
        List<Member> memberList;
        ReturnController returnController;
        List<ReturnTransaction> listReturnTransaction;
        DataGridViewCheckBoxColumn returnBox;

        public ItemReturnView()
        {
            InitializeComponent();
            returnTransaction = new ReturnTransaction();
            memberList = new List<Member>();
            returnController = new ReturnController();
            listReturnTransaction = new List<ReturnTransaction>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchMember()
        {
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            btnRestart.Enabled = true;
            try
            {
                mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string memberName = ("%" + txtCustomerFirstName.Text.ToString().ToUpper() + "%" + txtCustomerLastName.Text.ToString().ToUpper() + "%");
                string phoneNumber = ("%" + mtxtHomePhone.Text.ToString() + "%");
                if (!memberName.Equals("%%%") || !mtxtHomePhone.Text.Equals(""))
                {
                    if ((!txtCustomerFirstName.Text.Equals("") || !txtCustomerLastName.Equals("")))
                    {

                        memberList = returnController.GetMemberByName(memberName);
                        listReturnTransaction = new List<ReturnTransaction>();
                        for (int i = 0; i < memberList.Count(); i++)
                        {
                            listReturnTransaction.AddRange(returnController.GetRentedFurniture(memberList[i].memberID));
                        }
                    }

                    if (!mtxtHomePhone.Text.Equals(""))
                    {

                        memberList = returnController.GetMemberByPhone(phoneNumber);
                        listReturnTransaction = new List<ReturnTransaction>();
                        for (int i = 0; i < memberList.Count(); i++)
                        {
                            listReturnTransaction.AddRange(returnController.GetRentedFurniture(memberList[i].memberID));
                        }
                    }

                    DisplayReturn();
                    btnExit.Enabled = true;
                    btnRestart.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You must enter a name or phone number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayReturn()
        {
            if (memberList.Count == 0)
            {
                MessageBox.Show("No results. Please search again.");
                ClearForm();
            }
            else
            {
                BindingList<ReturnTransaction> bindingReturnList = new BindingList<ReturnTransaction>(listReturnTransaction);
                dataGridRentedItems.DataSource = bindingReturnList;
                dataGridRentedItems.AutoGenerateColumns = true;
                dataGridRentedItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //DataGridViewButtonColumn returnButton = new DataGridViewButtonColumn();
                returnBox = new DataGridViewCheckBoxColumn();
                returnBox.HeaderText = "Return Rental";
                returnBox.FalseValue = 0;
                returnBox.TrueValue = 1;
                returnBox.Name = "returnRental";
                dataGridRentedItems.Columns["fname"].HeaderText = "First Name";
                dataGridRentedItems.Columns["lname"].HeaderText = "Last Name";
                dataGridRentedItems.Columns["description"].HeaderText = "Description";
                dataGridRentedItems.Columns["furnitureID"].HeaderText = "Furniture ID";
                dataGridRentedItems.Columns["itemID"].HeaderText = "Item ID";
                dataGridRentedItems.Columns["Style"].HeaderText = "Style";
                dataGridRentedItems.Columns["Category"].HeaderText = "Category";
                dataGridRentedItems.Columns["rental_date"].HeaderText = "Rental Date";
                dataGridRentedItems.Columns["expected_return"].HeaderText = "Due Date";
                dataGridRentedItems.Columns["returnTransactionID"].Visible = false;
                dataGridRentedItems.Columns["transaction_date"].Visible = false;
                dataGridRentedItems.Columns["amount"].Visible = false;
                dataGridRentedItems.Columns["comment"].Visible = false;
                dataGridRentedItems.Columns["fines"].Visible = false;
                dataGridRentedItems.Columns["return_date"].Visible = false;
                dataGridRentedItems.Columns["employeeID"].Visible = false;
                dataGridRentedItems.Columns["memberID"].Visible = false;
                dataGridRentedItems.Columns["transactionID"].Visible = false;
                dataGridRentedItems.Columns["rentalID"].Visible = false;
                dataGridRentedItems.Columns["daily_Rate"].Visible = false;
                dataGridRentedItems.Columns["fine_Rate"].Visible = false;
                dataGridRentedItems.Enabled = true;
                if (dataGridRentedItems.Columns["returnRental"] == null)
                {
                    dataGridRentedItems.Columns.Insert(0, returnBox);
                }
                dataGridRentedItems.ReadOnly = false;

                foreach (DataGridViewColumn dc in dataGridRentedItems.Columns)
                {
                    if (dc.Index.Equals(0))
                    {
                        dc.ReadOnly = false;
                    }
                    else
                    {
                        dc.ReadOnly = true;
                    }
                }
            }
        }

        private void ClearForm()
        {
            dataGridRentedItems.DataSource = null;
            dataGridRentedItems.Columns.Clear();
            dataGridRentedItems.Rows.Clear();
            dataGridRentedItems.Refresh();
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = String.Empty;
                }
            }
        }

        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            SearchMember();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ItemReturnView_Load(object sender, EventArgs e)
        {
           
        }

        private void btnReturnItems_Click(object sender, EventArgs e)
        {
            if (dataGridRentedItems.ColumnCount == 0)
            {
                MessageBox.Show("There is no furniture to return.");
                return;
            }
            else if (!IsSelected())
            {
                MessageBox.Show("You have not selected any furniture to return.");
                return;
            }
            else 
            {
                List<DataGridViewRow> returnDataGridView = new List<DataGridViewRow>();
                listReturnTransaction = new List<ReturnTransaction>();
                foreach (DataGridViewRow row in dataGridRentedItems.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[returnBox.Name].Value) == true)
                    {
                        returnTransaction = new ReturnTransaction();
                        returnTransaction.fname = row.Cells["fname"].Value.ToString();
                        returnTransaction.lname = row.Cells["lname"].Value.ToString();
                        returnTransaction.description = row.Cells["description"].Value.ToString();
                        returnTransaction.style = row.Cells["Style"].Value.ToString();
                        returnTransaction.category = row.Cells["Category"].Value.ToString();
                        returnTransaction.rental_date = Convert.ToDateTime(row.Cells["rental_date"].Value.ToString());
                        returnTransaction.expected_return = Convert.ToDateTime(row.Cells["expected_return"].Value.ToString());
                        returnTransaction.itemID = Convert.ToInt32(row.Cells["itemID"].Value.ToString());
                        returnTransaction.furnitureID = Convert.ToInt32(row.Cells["furnitureID"].Value.ToString());
                        returnTransaction.memberID = Convert.ToInt32(row.Cells["memberID"].Value.ToString());
                        returnTransaction.rentalID = Convert.ToInt32(row.Cells["rentalID"].Value.ToString());
                        returnTransaction.fine_Rate = Convert.ToDecimal(row.Cells["fine_Rate"].Value.ToString());
                        returnTransaction.daily_Rate = Convert.ToDecimal(row.Cells["daily_Rate"].Value.ToString());
                        returnTransaction.amount = 0;
                        //Console.WriteLine("MemberID: " + returnTransaction.memberID.ToString() + "; Amount due: " + returnTransaction.amount.ToString());
                        returnTransaction.fines = 0;
                        //Console.WriteLine("MemberID: " + returnTransaction.memberID.ToString() + "; Fine due: " + returnTransaction.fines.ToString());
                        if (listReturnTransaction.Count >= 1)
                        {
                            if (!listReturnTransaction.Exists(x => x.memberID == returnTransaction.memberID))
                            {
                                MessageBox.Show("You can only return items for the same member.");
                                return;
                            }

                        }
                        listReturnTransaction.Add(returnTransaction);
                    } 
                }
                //Console.WriteLine(amountDue.ToString() + " " + fineDue.ToString());
                //Form frm = (Form)this.MdiParent;
                //MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
                //ToolStripMenuItem lt = (ToolStripMenuItem)ms.Items["login"];
                string login = "dEla"; // lt.Text;
                ReturnFurnitureView returnFurnitureView = new ReturnFurnitureView(listReturnTransaction, login, this);
                returnFurnitureView.Show();
            }
        }

        public bool IsSelected()
        {
            foreach (DataGridViewRow row in dataGridRentedItems.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                    return true;
            }
            return false;
        }

    }
 }

