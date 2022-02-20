using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class TourCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
    }
}
