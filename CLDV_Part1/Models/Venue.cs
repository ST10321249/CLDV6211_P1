using System.ComponentModel.DataAnnotations;

namespace CLDV_Part1.Models
{
    public class Venue
    {
        [Key] public int VenueId { get; set; }
        public string VenueName { get; set; }
        public string VenueLocation { get; set; }
        public int VenueCapacity { get; set; }
        public string VenueImageUrl { get; set; }
    }
}
