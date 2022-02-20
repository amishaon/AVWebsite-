using System;
using System.ComponentModel.DataAnnotations;
using AVWebsite.Models.Tour;

namespace AVWebsite.Models.HH
{
    public class Faq_HH
    {
        [Key]
        public int Id { get; set; }
        public TourFaq TourFaq { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
