using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class Facility_HH
    {
        [Key]
        public int Id { get; set; }
        public Facility Facility { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
