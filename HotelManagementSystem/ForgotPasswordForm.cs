using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Models;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                // To get username and password
                ForgotPassword forgotPassword = new ForgotPassword()
                {
                    Username = txtUsername.Text,
                    Pin = txtPin.Text
                };

                // To execute stored procedure
                var result = db.Query<User>("ForgotPassword", forgotPassword, commandType: CommandType.StoredProcedure).FirstOrDefault();

                if (result != null)
                {
                    // If username and pin is matched show password
                    MessageBox.Show("Your Password Is: " + result.Password);
                }
                else
                {
                    // Else show message box
                    MessageBox.Show("Invalid username or pin.");
                }
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
