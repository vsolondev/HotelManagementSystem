using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class CheckInForm : Form
    {
        private string roomId;

        public CheckInForm(string roomId)
        {
            InitializeComponent();

            this.roomId = roomId;
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtContactNumber.Clear();
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            txtRoomId.Text = roomId;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                // Insert Guest
                Guest guest = new Guest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text != "" ? txtMiddleName.Text : "",
                    ContactNumber = txtContactNumber.Text
                };

                db.Query<Guest>("CreateGuest", guest, commandType: CommandType.StoredProcedure);

                // Get Last Inserted Guest
                int guestId = db.QueryFirstOrDefault<int>("GetLastInsertedGuest", commandType: CommandType.StoredProcedure);
                int roomId = int.Parse(txtRoomId.Text);


                // We can now create Transaction with the Guest Id
                TransactionRecord transaction = new TransactionRecord()
                {
                    CheckInDate = dtpCheckInDate.Value,
                    CheckInTime = dtpCheckInTime.Value,
                    CheckOutDate = dtpCheckOutDate.Value,
                    CheckOutTime = dtpCheckOutTime.Value,
                    GuestId = guestId,
                    RoomId = roomId,
                    Status = "CheckIn"
                };

                // Insert Transction
                db.Query<TransactionRecord>("CreateTransactionRecord", transaction, commandType: CommandType.StoredProcedure);

                // Update selected room to occupied
                db.Query<TransactionRecord>("UpdateRoomToOccupied", new { roomId = roomId }, commandType: CommandType.StoredProcedure);

                ClearForm();

                this.Close();
                VacantRoomsForm vacantRoomsForm = new VacantRoomsForm();
                vacantRoomsForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
