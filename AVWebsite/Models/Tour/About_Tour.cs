using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class About_Tour
    {
        [Key]
        public int Id { get; set; }
        public About About { get; set; }
        public int AboutId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }
    }
}
