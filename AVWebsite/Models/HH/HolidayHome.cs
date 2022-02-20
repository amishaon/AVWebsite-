using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVWebsite.Models.HH
{
    public class HolidayHome
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FeatureImage { get; set; }
        public string FeaturePrice { get; set; }
        public Gallery Gallery { get; set; }
        [NotMapped]
        public int GalleryId { get; set; }
        public string Hightlights { get; set; }
        public string FullDescription { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
        public float AverageRating { get; set; }
        public Location PrimaryLocation { get; set; }
        [NotMapped]
        public int PrimaryLocationId { get; set; }
    }
}
