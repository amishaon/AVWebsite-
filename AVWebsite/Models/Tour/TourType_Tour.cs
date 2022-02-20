using System;
using System.ComponentModel.DataAnnotations;
using AVWebsite.Models.Tour;

namespace AVWebsite.Models.Tour
{
    public class TourType_Tour
    {
        [Key]
        public int Id { get; set; }
        public TourType TourType { get; set; }
        public int TourTypeId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }
    }
}
