using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class HHType_HH
    {
        [Key]
        public int Id { get; set; }
        public HHType HHType { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
