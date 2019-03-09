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

            // Hide up and down button
            txtCashOnHand.Controls[0].Hide();
            txtAdditionalCharges.Controls[0].Hide();

            this.transactionId = transactionId;


            var data = GetTransactionByTransactionId(transactionId);

            // Get Downpayment
            double downPayment = GetDownPaymentByTransactionId(transactionId);

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

            var checkOut = new DateTime(
                                            data.CheckOutDate.Year,
                                            data.CheckOutDate.Month,
                                            data.CheckOutDate.Day,
                                            data.CheckOutTime.Hour,
                                            data.CheckOutTime.Minute,
                                            data.CheckOutTime.Second
                                      );

            var numberOfDays = Math.Ceiling( (checkOut - checkIn).TotalDays );

            lblNumberOfDays.Text = numberOfDays.ToString();
            lblBasePrice.Text = (numberOfDays * data.RoomPrice).ToString();
            lblTotalPrice.Text = lblBasePrice.Text;

            if (downPayment >= double.Parse(lblTotalPrice.Text))
            {
                lblChange.Text = (downPayment - double.Parse(lblTotalPrice.Text)).ToString();
            }
            else
            {
                lblChange.Text = "0";
            }

            lblDownPayment.Text = downPayment.ToString();
        }

        private TransactionRecordRoomGuest GetTransactionByTransactionId(string transactionId)
        {
            using (var db = DatabaseConnection.Connect())
            {
                var transactionRecordRoomGuests = db.Query<TransactionRecordRoomGuest>("GetTransactionByTransactionId", new { TransactionId = transactionId }, commandType: CommandType.StoredProcedure).ToList().FirstOrDefault();

                return transactionRecordRoomGuests;
            }
        }

        private double GetDownPaymentByTransactionId(string transactionId)
        {
            using (var db = DatabaseConnection.Connect())
            {
                double downPayment = db.Query<double>("GetDownPaymentByTransactionId", new { TransactionId = transactionId }, commandType: CommandType.StoredProcedure).ToList().FirstOrDefault();

                return downPayment;
            }
        }

        private void txtCashOnHand_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCashOnHand.Text == "")
            {
                txtCashOnHand.Text = "0";
            }
            
            double additionalCharges = double.Parse(txtAdditionalCharges.Value.ToString());
            double basePrice = double.Parse(lblBasePrice.Text);
            double cashOnHand = double.Parse(txtCashOnHand.Value.ToString());
            double downPayment = double.Parse(lblDownPayment.Text);

            lblTotalPrice.Text = (basePrice + additionalCharges).ToString();

            double change = (cashOnHand + downPayment) - (basePrice + additionalCharges);
            if (change >= 0)
            {
                lblChange.Text = change.ToString();
            }
            else
            {
                lblChange.Text = "0";
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            double downPayment = double.Parse(lblDownPayment.Text);
            double cashOnHand = double.Parse(txtCashOnHand.Text);
            double totalPrice = double.Parse(lblTotalPrice.Text);

            if (downPayment + cashOnHand >= totalPrice)
            {
                using (var db = DatabaseConnection.Connect())
                {
                    // To prevent changing the database again after checkout
                    if (isCheckedOut == false)
                    {
                        //Update Payment
                        Payment payment = new Payment()
                        {
                            AdditionalCharges = double.Parse(txtAdditionalCharges.Value.ToString()),
                            BasePrice = double.Parse(lblBasePrice.Text),
                            TotalPrice = totalPrice,
                            CashOnHand = cashOnHand,
                            CashChange = double.Parse(lblChange.Text),
                            DateOfPayment = DateTime.Now,
                            TimeOfPayment = DateTime.Now,
                            TransactionId = int.Parse(txtTransactionId.Text)
                        };

                        db.Query<Payment>("UpdatePayment", payment, commandType: CommandType.StoredProcedure);

                        // Get TransactionId and update the TransactionRecord Status to CheckOut
                        db.QueryFirstOrDefault<int>("UpdateTransactionRecordToCheckOut", new { TransactionId = int.Parse(txtTransactionId.Text) }, commandType: CommandType.StoredProcedure);

                        // Get RoomId and update the Room Status to Vacant
                        db.QueryFirstOrDefault<int>("UpdateRoomToVacant", new { RoomId = int.Parse(txtRoomId.Text) }, commandType: CommandType.StoredProcedure);

                        isCheckedOut = true;
                    }

                    // Maximized Print Preview Dialog
                    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;

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
            var font = new Font("Times New Roman", 18, FontStyle.Regular);
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
                "Base Price : " + lblBasePrice.Text,
                font,
                brush,
                new PointF(50, 180)
            );

            e.Graphics.DrawString(
                "Total Price : " + lblTotalPrice.Text,
                font,
                brush,
                new PointF(50, 210)
            );

            e.Graphics.DrawString(
                "Down Payment : " + lblDownPayment.Text,
                font,
                brush,
                new PointF(50, 240)
            );

            e.Graphics.DrawString(
                "Cash on Hand : " + txtCashOnHand.Text,
                font,
                brush,
                new PointF(50, 270)
            );

            e.Graphics.DrawString(
                "Change : " + lblChange.Text,
                font,
                brush,
                new PointF(50, 300)
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            OccupiedRoomsForm occupiedRoomsForm = new OccupiedRoomsForm();
            occupiedRoomsForm.Show();
        }

        private void txtAdditionalCharges_KeyUp(object sender, KeyEventArgs e)
        {
            double additionalCharges = double.Parse(txtAdditionalCharges.Value.ToString());
            double basePrice = double.Parse(lblBasePrice.Text);
            double cashOnHand = double.Parse(txtCashOnHand.Value.ToString());
            double downPayment = double.Parse(lblDownPayment.Text);

            lblTotalPrice.Text = (basePrice + additionalCharges).ToString();

            double change = (cashOnHand + downPayment) - (basePrice + additionalCharges);
            if (change >= 0)
            {
                lblChange.Text = change.ToString();
            }
            else
            {
                lblChange.Text = "0";
            }
        }
    }
}
