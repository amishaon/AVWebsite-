using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class HHPackage_Amenities
    {
        [Key]
        public int Id { get; set; }
        public RoomAmenities RoomAmenities { get; set; }
        public HHPackage HHPackage { get; set; }
    }
}
