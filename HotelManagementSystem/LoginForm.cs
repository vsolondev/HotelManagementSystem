using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Models;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                // To get username and password
                LoginUser loginUser = new LoginUser()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                // To execute stored procedure
                var result = db.Query<User>("LoginUser", loginUser, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (result != null)
                {
                    // If username and password is matched show vacant rooms
                    this.Hide();

                    if (result.Role == "Admin")
                    {
                        AdminHomeForm adminHomeForm = new AdminHomeForm();
                        adminHomeForm.Show();
                    }
                    else
                    {
                        VacantRoomsForm vacantRoomsForm = new VacantRoomsForm();
                        vacantRoomsForm.Show();
                    }
                }
                else
                {
                    // Else show message box
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();

            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
        }
    }
}
