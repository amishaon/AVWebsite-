using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class Location_Tours
    {
        [Key]
        public int Id { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }


    }
}
