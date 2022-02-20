using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class Room_HH
    {
        [Key]
        public int Id { get; set; }
        public Room Room { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
