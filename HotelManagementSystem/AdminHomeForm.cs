using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void vacantRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            VacantRoomsForm vacantRoomsForm = new VacantRoomsForm();
            vacantRoomsForm.Show();
        }

        private void occupiedRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            OccupiedRoomsForm occupiedRoomsForm = new OccupiedRoomsForm();
            occupiedRoomsForm.Show();
        }

        private void userStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
