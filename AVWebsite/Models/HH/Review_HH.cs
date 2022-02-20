using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class Review_HH
    {
        [Key]
        public int Id { get; set; }
        public Review Review { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
