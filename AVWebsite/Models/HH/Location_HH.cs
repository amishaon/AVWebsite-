using System;
namespace AVWebsite.Models.HH
{
    public class Location_HH
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
