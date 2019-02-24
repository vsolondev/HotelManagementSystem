using System;

namespace HotelManagementSystem.JoinTables
{
    public class TransactionRecordRoomGuest
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public double RoomPrice { get; set; }
        public int MaximumPerson { get; set; }
        public string RoomStatus { get; set; }
        public int TransactionId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckInTime { get; set; }
        public string TransactionStatus { get; set; }
        public int GuestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string ContactNumber { get; set; }
    }
}
