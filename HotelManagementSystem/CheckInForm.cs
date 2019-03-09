using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class CheckInForm : Form
    {
        public CheckInForm(string roomId)
        {
            InitializeComponent();

            txtRoomId.Text = roomId;
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtContactNumber.Clear();
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
                    ContactNumber = txtContactNumber.Text,
                    Accompany = txtAccompany.Text
                };

                db.Query<Guest>("CreateGuest", guest, commandType: CommandType.StoredProcedure);

                // Get Last Inserted Guest
                int guestId = db.QueryFirstOrDefault<int>("GetLastInsertedGuest", commandType: CommandType.StoredProcedure);
                int roomId = int.Parse(txtRoomId.Text);

                // We can now create Transaction with the Guest Id
                TransactionRecord transaction = new TransactionRecord()
                {
                    CheckInDate = DateTime.Now,
                    CheckInTime = DateTime.Now,
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

                // Get Last Inserted Transaction Record
                int transactionId = db.QueryFirstOrDefault<int>("GetLastInsertedTransactionRecord", commandType: CommandType.StoredProcedure);

                //Insert Payment to add downpayment
                Payment payment = new Payment()
                {
                    DownPayment = double.Parse(txtDownPayment.Value.ToString()),
                    BasePrice = 0,
                    TotalPrice = 0,
                    CashOnHand = 0,
                    CashChange = 0,
                    DateOfPayment = DateTime.Now,
                    TimeOfPayment = DateTime.Now,
                    TransactionId = transactionId
                };

                db.Query<Payment>("CreatePayment", payment, commandType: CommandType.StoredProcedure);

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
