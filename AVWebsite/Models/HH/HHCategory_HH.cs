using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class HHCategory_HH
    {
        [Key]
        public int Id { get; set; }
        public HHCategory HHCategory { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
