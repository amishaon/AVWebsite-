using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class TourFaq
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }
    }
}
