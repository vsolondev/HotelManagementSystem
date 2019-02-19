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
using HotelManagementSystem.JoinTables;
using HotelManagementSystem.Tables;

namespace HotelManagementSystem
{
    public partial class CheckOutForm : Form
    {
        private string transactionId;

        public CheckOutForm(string transactionId)
        {
            InitializeComponent();

            this.transactionId = transactionId;


            var data = GetTransactionByTransactionId(transactionId);

            txtTransactionId.Text = transactionId;

            txtRoomId.Text = data.RoomId.ToString();
            lblCheckInDate.Text = data.CheckInDate.ToShortDateString();
            lblCheckInTime.Text = data.CheckInTime.ToShortTimeString();
            lblCheckOutDate.Text = data.CheckOutDate.ToShortDateString();
            lblCheckOutTime.Text = data.CheckOutTime.ToShortTimeString();
            lblRoomName.Text = data.RoomName.ToString();
            lblRoomType.Text = data.RoomType.ToString();
            lblGuestName.Text = data.FirstName + " " + data.MiddleName + " " + data.LastName;

            lblRoomPrice.Text = data.RoomPrice.ToString();

            // Get number of days
            var checkIn = new DateTime(
                                            data.CheckInDate.Year,
                                            data.CheckInDate.Month,
                                            data.CheckInDate.Day,
                                            data.CheckInTime.Hour,
                                            data.CheckInTime.Minute,
                                            data.CheckInTime.Second
                                      );
            var numberOfDays = Math.Ceiling( (DateTime.Now - checkIn).TotalDays );

            lblNumberOfDays.Text = numberOfDays.ToString();
            lblTotalPrice.Text = (numberOfDays * data.RoomPrice).ToString();
        }

        private TransactionRecordRoomGuest GetTransactionByTransactionId(string transactionId)
        {
            using (var db = DatabaseConnection.Connect())
            {
                var transactionRecordRoomGuests = db.Query<TransactionRecordRoomGuest>("GetTransactionByTransactionId", new { TransactionId = transactionId }, commandType: CommandType.StoredProcedure).ToList().FirstOrDefault();

                return transactionRecordRoomGuests;
            }
        }

        private void txtCashOnHand_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCashOnHand.Text == "")
            {
                txtCashOnHand.Text = "0";
            }

            double change = double.Parse(txtCashOnHand.Text) - double.Parse(lblTotalPrice.Text);

            lblChange.Text = change.ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            using (var db = DatabaseConnection.Connect())
            {
                // Insert Payment
                Payment payment = new Payment()
                {
                    TotalPrice = double.Parse(lblTotalPrice.Text),
                    CashOnHand = double.Parse(txtCashOnHand.Text),
                    CashChange = double.Parse(lblChange.Text),
                    DateOfPayment = DateTime.Now,
                    TimeOfPayment = DateTime.Now,
                    TransactionId = int.Parse(txtTransactionId.Text)
                };

                db.Query<Payment>("CreatePayment", payment, commandType: CommandType.StoredProcedure);

                // Get TransactionId and update the TransactionRecord Status to CheckOut
                db.QueryFirstOrDefault<int>("UpdateTransactionRecordToCheckOut", new { TransactionId = int.Parse(txtTransactionId.Text) }, commandType: CommandType.StoredProcedure);

                // Get RoomId and update the Room Status to Vacant
                db.QueryFirstOrDefault<int>("UpdateRoomToVacant", new { RoomId = int.Parse(txtRoomId.Text) }, commandType: CommandType.StoredProcedure);
            }
            
        }
    }
}
