using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class About_HH
    {
        [Key]
        public int Id { get; set; }
        public About About { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
