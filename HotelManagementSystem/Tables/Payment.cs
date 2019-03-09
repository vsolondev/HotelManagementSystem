using System;

namespace HotelManagementSystem.Tables
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public double DownPayment { get; set; }
        public double AdditionalCharges { get; set; }
        public double BasePrice { get; set; }
        public double TotalPrice { get; set; }
        public double CashOnHand { get; set; }
        public double CashChange { get; set; }
        public DateTime DateOfPayment { get; set; }
        public DateTime TimeOfPayment { get; set; }
        public int TransactionId { get; set; }
    }
}
