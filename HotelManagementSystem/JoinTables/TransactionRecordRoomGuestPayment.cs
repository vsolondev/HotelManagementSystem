using System;

namespace HotelManagementSystem.JoinTables
{
    class TransactionRecordRoomGuestPayment
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public double RoomPrice { get; set; }
        public double DownPayment { get; set; }
        public double AdditionalCharges { get; set; }
        public double BasePrice { get; set; }
        public double TotalPrice { get; set; }
        public double CashOnHand { get; set; }
        public double CashChange { get; set; }
        public DateTime DateOfPayment { get; set; }
        public DateTime TimeOfPayment { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Accompany { get; set; }
    }
}
