using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class TourPackage_Tour
    {
        [Key]
        public int Id { get; set; }
        public TourPackage TourPackage { get; set; }
        public int TourPackageId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }
    }
}
