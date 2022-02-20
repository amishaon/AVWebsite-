using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class RoomAmenities
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
