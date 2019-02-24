using System;

namespace HotelManagementSystem.Tables
{
    public class TransactionRecord
    {
        public int TransactionId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckInTime { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public string Status { get; set; }
    }
}
