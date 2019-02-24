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
        private bool isCheckedOut = false;

        public CheckOutForm(string transactionId)
        {
            InitializeComponent();

            this.transactionId = transactionId;


            var data = GetTransactionByTransactionId(transactionId);

            txtTransactionId.Text = transactionId;
            txtRoomId.Text = data.RoomId.ToString();
            lblCheckInDate.Text = data.CheckInDate.ToShortDateString();
            lblCheckInTime.Text = data.CheckInTime.ToShortTimeString();
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
            double cashOnHand = double.Parse(txtCashOnHand.Text);
            double totalPrice = double.Parse(lblTotalPrice.Text);

            if (cashOnHand > totalPrice)
            {
                using (var db = DatabaseConnection.Connect())
                {
                    // To prevent changing the database again after checkout
                    if (isCheckedOut == false)
                    {
                        //Insert Payment
                        Payment payment = new Payment()
                        {
                            TotalPrice = totalPrice,
                            CashOnHand = cashOnHand,
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

                        isCheckedOut = true;
                    }

                    // Print Receipt
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cash On Hand must be greater than Total Price.");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font = new Font("Times New Roman", 14, FontStyle.Regular);
            var brush = Brushes.Black;

            e.Graphics.DrawString(
                "Check-in Date and Time : " + lblCheckInDate.Text + " " + lblCheckInTime.Text,
                font,
                brush,
                new PointF(50, 30)
            );

            e.Graphics.DrawString(
                "Check-out Date and Time : " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(),
                font,
                brush,
                new PointF(50, 60)
            );

            e.Graphics.DrawString(
                "Room Name : " + lblRoomName.Text,
                font,
                brush,
                new PointF(50, 90)
            );

            e.Graphics.DrawString(
                "Room Type : " + lblRoomType.Text,
                font,
                brush,
                new PointF(50, 120)
            );

            e.Graphics.DrawString(
                "Room Price : " + lblRoomPrice.Text,
                font,
                brush,
                new PointF(50, 150)
            );

            e.Graphics.DrawString(
                "Total Price : " + lblTotalPrice.Text,
                font,
                brush,
                new PointF(50, 180)
            );

            e.Graphics.DrawString(
                "Cash on Hand : " + txtCashOnHand.Text,
                font,
                brush,
                new PointF(50, 210)
            );

            e.Graphics.DrawString(
                "Change : " + lblChange.Text,
                font,
                brush,
                new PointF(50, 240)
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            OccupiedRoomsForm occupiedRoomsForm = new OccupiedRoomsForm();
            occupiedRoomsForm.Show();
        }
    }
}
