using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            SearchUsers();
        }

        private void SearchUsers(string searchString = "")
        {
            using (var db = DatabaseConnection.Connect())
            {
                dgvUser.DataSource = db.Query<User>("SearchUsers", new { searchString = searchString }, commandType: CommandType.StoredProcedure).ToList();
                dgvUser.Columns["Pin"].Visible = false;
            }
        }


        private void ClearForm()
        {
            txtUserId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPin.Clear();
            cbRole.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                User user = new User()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Pin = txtPin.Text,
                    Role = cbRole.SelectedItem.ToString()
                };

                db.Query<User>("CreateUser", user, commandType: CommandType.StoredProcedure);

                SearchUsers();
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                User user = new User()
                {
                    UserId = int.Parse(txtUserId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Pin = txtPin.Text,
                    Role = cbRole.SelectedItem.ToString()
                };

                db.Query<User>("UpdateUser", user, commandType: CommandType.StoredProcedure);

                SearchUsers();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchUsers(txtSearch.Text);
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvUser.CurrentRow.Cells;

            txtUserId.Text = cells[0].Value.ToString();
            txtFirstName.Text = cells[1].Value.ToString();
            txtLastName.Text = cells[2].Value.ToString();
            txtMiddleName.Text = cells[3].Value != null ? cells[3].Value.ToString() : "";
            txtUsername.Text = cells[4].Value.ToString();
            txtPassword.Text = cells[5].Value.ToString();
            txtPin.Text = cells[6].Value.ToString();
            cbRole.Text = cells[7].Value.ToString();
        }
    }
}
