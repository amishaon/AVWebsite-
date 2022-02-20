using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class Review_Tour
    {
        [Key]
        public int Id { get; set; }
        public Review Review { get; set; }
        public int ReviewId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }
    }
}
