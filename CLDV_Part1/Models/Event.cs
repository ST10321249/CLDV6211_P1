using System.ComponentModel.DataAnnotations;

namespace CLDV_Part1.Models
{
    public class Event
    {
        [Key] public int EventId { get; set; }
        public string EventName { get; set; }
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }

    }
}
