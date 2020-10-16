using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class Dashboard : Form
    {
        private readonly LoggedInUserModel _loggedInUser;
        List<UserModel> users = new List<UserModel>();

        public Dashboard(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            this._loggedInUser = loggedInUser;
            txtUserFullName.Text = _loggedInUser.Fullname;
            txtUserRole.Text = _loggedInUser.UserRole;
            txtBusinessName.Text = BusinessInformation.BusinessInfo[0].BusinessName;
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("D");
            txtTime.Text = DateTime.Now.ToString("T");
        }

        private void RefreshGrid()
        {
            SQLDataAccess dataAccess = new SQLDataAccess();
            users = dataAccess.LoadAllUsers();
            userGridView.DataSource = users;
            txtTotalStaff.Text = String.Format(txtTotalStaff.Text, users.Count.ToString());
            this.ClearValues();
        } 

        private void ClearValues()
        {
            txtUserId.Text = "";
            txtFullName.Text = "";
            txtUserName.Text = "";
            cmbUserRole.SelectedIndex = 0;
            txtContact.Text = "";
            txtEmailAddress.Text = "";
            txtNewPassword.Text = "";
            txtNewVerifyPassword.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadDashboard()
        {
            dashPanel.Visible = true;

            staffPanel.Visible = false;
            //TODO: Make all other panels invisible
        }

        private void LoadStaffPanel()
        {
            staffPanel.Visible = true;
            txtStaffSearch.Focus();
            cmbSearchUserBy.SelectedIndex = 0;
            cmbUserRole.SelectedIndex = 0;

            dashPanel.Visible = false;
            //TODO: Make all other panels invisible

            this.RefreshGrid();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.LoadDashboard();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.LoadStaffPanel();
        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            if (e.RowIndex != -1)
            {
                DataGridViewRow grid = userGridView.Rows[e.RowIndex];
                txtUserId.Text = grid.Cells[0].Value.ToString();
                txtFullName.Text = grid.Cells[1].Value.ToString();
                txtUserName.Text = grid.Cells[2].Value.ToString();
                cmbUserRole.SelectedItem = grid.Cells[3].Value.ToString();
                txtContact.Text = grid.Cells[4].Value.ToString();
                txtEmailAddress.Text = grid.Cells[5].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtNewPassword.Text != "") && (txtNewVerifyPassword.Text != ""))
            {
                //TODO: Update with password
                if (txtNewPassword.Text == txtNewVerifyPassword.Text)
                {
                    MessageBox.Show("With passwords");
                    this.RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Passwords dont match");
                }
            }
            else if((txtNewPassword.Text == "") && (txtNewVerifyPassword.Text == ""))
            {
                //TODO: Update without passwords
                MessageBox.Show("Without passwords");
                this.RefreshGrid();
            }
            else 
            {
                MessageBox.Show("Put passwords");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TODO: Delete user || set status to 0
            this.RefreshGrid();
        }

        private void txtStaffSearch_TextChanged(object sender, EventArgs e)
        {
            var result = users.Where(x => x.Username.Contains(txtStaffSearch.Text) || x.Fullname.Contains(txtStaffSearch.Text) || x.Contact.Contains(txtStaffSearch.Text)).ToList();
            userGridView.DataSource = result;
        }

        private void cmbSearchUserBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roleText = cmbSearchUserBy.GetItemText(cmbSearchUserBy.SelectedItem);
            var result = users.Where(x => x.UserRole.Contains(roleText)).ToList();
            userGridView.DataSource = result;
        }
    }
}
