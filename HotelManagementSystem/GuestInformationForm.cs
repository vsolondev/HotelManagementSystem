using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class GuestInformationForm : Form
    {
        public GuestInformationForm(Guest guest)
        {
            InitializeComponent();

            txtGuestId.Text = guest.GuestId.ToString();
            txtFirstName.Text = guest.FirstName;
            txtLastName.Text = guest.LastName;
            txtMiddleName.Text = guest.MiddleName;
            txtContactNumber.Text = guest.ContactNumber;
            txtAccompany.Text = guest.Accompany;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                Guest guest = new Guest()
                {
                    GuestId = int.Parse(txtGuestId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    ContactNumber = txtContactNumber.Text,
                    Accompany = txtAccompany.Text,
                };

                db.Query<Guest>("UpdateGuest", guest, commandType: CommandType.StoredProcedure);

                this.Close();
            }
        }

        private void GuestInformationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OccupiedRoomsForm occupiedRoomsForm = new OccupiedRoomsForm();
            occupiedRoomsForm.Show();
        }
    }
}
