using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class Room_RoomAmenities
    {
        [Key]
        public int Id { get; set; }
        public Room Room { get; set; }
        public RoomAmenities RoomAmenities { get; set; }
    }
}
