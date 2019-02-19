namespace HotelManagementSystem.Tables
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public double RoomPrice { get; set; }
        public int MaximumPerson { get; set; }
        public string Status { get; set; }
    }
}
