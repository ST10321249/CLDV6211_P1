using System.ComponentModel.DataAnnotations;

namespace CLDV_Part1.Models
{
    public class Booking
    {
        [Key] public int BookingID { get; set; }
        public string EventName { get; set; }
        public Event? Events { get; set; }
        public string VenueName { get; set; }
        public Venue? Venues { get; set; }
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

    }
}
