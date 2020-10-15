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

        private void LoadDashboard()
        {
            dashPanel.Visible = true;

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

            SQLDataAccess dataAccess = new SQLDataAccess();
            List<UserModel> users = dataAccess.LoadAllUsers();
            userGridView.DataSource = users;
            txtTotalStaff.Text = String.Format(txtTotalStaff.Text, users.Count.ToString());
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
    }
}
