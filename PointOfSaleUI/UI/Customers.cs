﻿using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.Helpers;
using PointOfSale.Lib.Models;
using PointOfSale.Lib.TerminalModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class Customers : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<CustomerDataModel> Customer = new List<CustomerDataModel>();
        private readonly LoggedInUserModel _loggedInUser;

        public Customers(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            cmbSearchCustomerBy.SelectedIndex = 0;
            this.GetAllCustomers();
            this._loggedInUser = loggedInUser;
            switch (_loggedInUser.UserRole)
            {
                case "Cashier":
                    btnDeleteCustomer.Enabled = false;
                    break;
            }
        }

        private void ClearAll()
        {
            txtCustomerId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtAddressOne.Clear();
            txtAddressTwo.Clear();
            txtPin.Clear();
        }

        private void GetAllCustomers()
        {
            Customer = dataAccess.GetAllCustomers();
            if (Customer.Count > 0)
            {
                lblNoCustomers.Visible = false;
                customersGridView.Visible = true;
                txtCustomerSearch.Enabled = true;
                txtCustomerSearch.Focus();
                customersGridView.DataSource = Customer;
            }
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearchCustomerBy.GetItemText(cmbSearchCustomerBy.SelectedItem))
            {
                case "Name":
                    var NameResult = Customer.Where(x => x.CustomerName.ToString().Contains(txtCustomerSearch.Text)).ToList();
                    customersGridView.DataSource = NameResult;
                    break;
                case "Email":
                    var EmailResult = Customer.Where(x => x.CustomerEmail.Contains(txtCustomerSearch.Text)).ToList();
                    customersGridView.DataSource = EmailResult;
                    break;
                case "Contact":
                    var ContactResult = Customer.Where(x => x.CustomerPhone.Contains(txtCustomerSearch.Text)).ToList();
                    customersGridView.DataSource = ContactResult;
                    break;
            }
        }

        private void customersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(customersGridView.CurrentRow.Cells[0].Value);
            CheckOutDataModel.CustomerId = Id;
            this.DialogResult = DialogResult.OK;
        }

        private void customersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_loggedInUser.UserRole != "Cashier")
            {
                btnUpdateCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnAddCustomer.Enabled = false;
                if (e.RowIndex != -1)
                {
                    DataGridViewRow grid = customersGridView.Rows[e.RowIndex];
                    txtCustomerId.Text = grid.Cells[0].Value.ToString();
                    txtName.Text = grid.Cells[1].Value.ToString();
                    txtEmail.Text = grid.Cells[2].Value.ToString();
                    txtContact.Text = grid.Cells[3].Value.ToString();
                    txtAddressOne.Text = grid.Cells[4].Value.ToString();
                    if (grid.Cells[5].Value == null)
                    {
                        txtAddressTwo.Text = "None";
                    }
                    else
                    {
                        txtAddressTwo.Text = grid.Cells[5].Value.ToString();
                    }
                    txtPin.Text = grid.Cells[6].Value.ToString();
                }
                else
                {
                    Messages.DisplayMessage("Not authorized to edit or delete", lblWarning, Color.Red);
                }
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //TODO: Update Customer
            CustomerDataModel customerData = new CustomerDataModel
            {
                CustomerId = Convert.ToInt32(txtCustomerId.Text),
                CustomerName = txtName.Text,
                CustomerAddressLine1 = txtAddressOne.Text,
                CustomerAddressLine2 = txtAddressTwo.Text,
                CustomerAddressPin = txtPin.Text,
                CustomerEmail = txtEmail.Text,
                CustomerPhone = txtContact.Text
            };

            dataAccess.SaveData("dbo.UpdateCustomer", customerData, "POS");
            this.ClearAll();
            btnUpdateCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            this.GetAllCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //TODO: Update Customer
            int CustomerID = Convert.ToInt32(txtCustomerId.Text);
            dataAccess.SaveData("dbo.DeleteCustomer", new { CustomerID }, "POS");
            this.ClearAll();
            btnUpdateCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            this.GetAllCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //TODO: Add New Customer
            CustomerModel customer = new CustomerModel
            {
                CustomerName = txtName.Text,
                CustomerAddressLine1 = txtAddressOne.Text,
                CustomerAddressLine2 = txtAddressTwo.Text,
                CustomerAddressPin = txtPin.Text,
                CustomerEmail = txtEmail.Text,
                CustomerPhone = txtContact.Text
            };

            dataAccess.SaveData("dbo.SaveCustomer", customer, "POS");
            btnUpdateCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            this.ClearAll();
            this.GetAllCustomers();
        }
    }
}
