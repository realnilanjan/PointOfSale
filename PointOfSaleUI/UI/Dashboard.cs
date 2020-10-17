using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Encryptions;
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
        string IsBlocked = "1";  //1 Is not blocked || 0 is blocked

        public Dashboard(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            this._loggedInUser = loggedInUser;
            txtUserFullName.Text = _loggedInUser.Fullname;
            txtUserRole.Text = _loggedInUser.UserRole;
            txtBusinessName.Text = BusinessInformation.BusinessInfo[0].BusinessName;
        }

        #region Functions
        private void RefreshGrid()
        {
            SQLDataAccess dataAccess = new SQLDataAccess();
            users = dataAccess.LoadAllUsers();
            userGridView.DataSource = users;
            txtTotalStaff.Text = String.Format(Properties.Resources.NO_OF_STAFFS, users.Count.ToString());
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

            //TODO: Make all other panels invisible
            staffPanel.Visible = false;
            categoryPanel.Visible = false;

            //Refresh Data
        }

        private void LoadStaffPanel()
        {
            staffPanel.Visible = true;
            cmbSearchUserBy.SelectedIndex = 0;
            cmbUserRole.SelectedIndex = 0;

            //TODO: Make all other panels invisible
            dashPanel.Visible = false;
            categoryPanel.Visible = false;




            //Refresh Data
            this.RefreshGrid();
        }

        private void LoadCategoryPanel()
        {
            categoryPanel.Visible = true;

            //Make all other panel invisible
            dashPanel.Visible = false;
            staffPanel.Visible = false;

            //Refresh Data
        }

        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 55)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 300;
                panelAnimator2.ShowSync(sideMenu);
                textAnimator.Hide(smalllogo);
                logoAnimator.ShowSync(biglogo);
                textAnimator.ShowSync(userInfo);
                textAnimator.ShowSync(dateInfo);
            }
            else
            {
                logoAnimator.Hide(biglogo);
                textAnimator.Hide(userInfo);
                textAnimator.Hide(dateInfo);
                sideMenu.Visible = false;
                sideMenu.Width = 55;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(smalllogo);
            }
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("D");
            txtTime.Text = DateTime.Now.ToString("T");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.LoadDashboard();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.LoadStaffPanel();
        }
               
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtNewPassword.Text != "") && (txtNewVerifyPassword.Text != ""))
            {
                //TODO: Update with password
                if (txtNewPassword.Text == txtNewVerifyPassword.Text)
                {
                    WithPasswordModel user = new WithPasswordModel
                    {
                        UserId = Convert.ToInt32(txtUserId.Text),
                        Fullname = txtUserFullName.Text,
                        Username = txtUserName.Text,
                        Password = EncryptTo.MD5Hash(txtNewVerifyPassword.Text),
                        UserRole = cmbUserRole.GetItemText(cmbUserRole.SelectedItem),
                        Contact = txtContact.Text,
                        EmailAddress = txtEmailAddress.Text,
                        Status = IsBlocked
                    };

                    SQLDataAccess dataAccess = new SQLDataAccess();
                    dataAccess.SaveData("dbo.UpdateUserWithPassword", user, "POS");
                    this.RefreshGrid();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.PASS_DONT_MATCH, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ((txtNewPassword.Text == "") && (txtNewVerifyPassword.Text == ""))
            {
                WithoutPasswordModel user = new WithoutPasswordModel
                {
                    UserId = Convert.ToInt32(txtUserId.Text),
                    Fullname = txtUserFullName.Text,
                    Username = txtUserName.Text,
                    UserRole = cmbUserRole.GetItemText(cmbUserRole.SelectedItem),
                    Contact = txtContact.Text,
                    EmailAddress = txtEmailAddress.Text,
                    Status = IsBlocked
                };

                SQLDataAccess dataAccess = new SQLDataAccess();
                dataAccess.SaveData("dbo.UpdateUserWithoutPassword", user, "POS");
                this.RefreshGrid();
            }
            else
            {
                MessageBox.Show(Properties.Resources.PUT_PASSWORDS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStaffSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearchUserBy.GetItemText(cmbSearchUserBy.SelectedItem))
            {
                case "ID":
                    var IdResult = users.Where(x => x.UserId.ToString().Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = IdResult;
                    break;
                case "Full Name":
                    var NameResult = users.Where(x => x.Fullname.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = NameResult;
                    break;
                case "Username":
                    var UsernameResult = users.Where(x => x.Username.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = UsernameResult;
                    break;
                case "User Role":
                    var UserRoleResult = users.Where(x => x.UserRole.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = UserRoleResult;
                    break;
                case "Contact Number":
                    var ContactResult = users.Where(x => x.Contact.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = ContactResult;
                    break;
                case "Email Address":
                    var EmailResult = users.Where(x => x.EmailAddress.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = EmailResult;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this user?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int UserId = Convert.ToInt32(txtUserId.Text);
                SQLDataAccess dataAccess = new SQLDataAccess();
                dataAccess.SaveData("dbo.DeleteUser", new { UserId = UserId }, "POS");
                this.RefreshGrid();
            }
            else { return; }
        }

        private void cmbSearchUserBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchUserBy.SelectedIndex > 0)
            {
                txtStaffSearch.Enabled = true;
            }
        }

        private void chkBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlock.CheckState == CheckState.Checked)
            {
                IsBlocked = "0";
            }
            else
            {
                IsBlocked = "1";
            }
        }

        private void chkShowPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswords.CheckState == CheckState.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewVerifyPassword.UseSystemPasswordChar = false;
                chkShowPasswords.Text = "Hide Password";
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewVerifyPassword.UseSystemPasswordChar = true;
                chkShowPasswords.Text = "Show Password";
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            NewStaff staff = new NewStaff();
            DialogResult result = staff.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.RefreshGrid();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.LoadCategoryPanel();
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
                cmbUserRole.SelectedItem = grid.Cells[4].Value.ToString();
                txtContact.Text = grid.Cells[5].Value.ToString();
                txtEmailAddress.Text = grid.Cells[6].Value.ToString();
                if (grid.Cells[7].Value.ToString() == "0")
                {
                    chkBlock.CheckState = CheckState.Checked;
                }
                else
                {
                    chkBlock.CheckState = CheckState.Unchecked;
                }
            }
        }
    }
}