using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class TourCategory_Tour
    {
        [Key]
        public int Id { get; set; }
        public TourCategory TourCategory { get; set; }
        public int TourCategoryId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }
    }
}
