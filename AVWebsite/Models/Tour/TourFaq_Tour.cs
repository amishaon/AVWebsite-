using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class TourFaq_Tour
    {
        [Key]
        public int Id { get; set; }
        public TourFaq TourFaq { get; set; }
        public int TourFaqId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }

    }
}
