using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class HHPackage_HH
    {
        [Key]
        public int Id { get; set; }
        public HHPackage HHPackage { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
