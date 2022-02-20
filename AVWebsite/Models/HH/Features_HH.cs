using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class Features_HH
    {
        [Key]
        public int Id { get; set; }
        public Features Features { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
