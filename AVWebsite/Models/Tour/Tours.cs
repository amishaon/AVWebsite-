using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.FlowAnalysis;

namespace AVWebsite.Models.Tour
{
    public class Tours
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FeatureImage { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
       
        public int FeaturePrice { get; set; }
        public string FeaturePriceText { get; set; }
        public Gallery Gallery { get; set; }
        public int GalleryId { get; set; }
        public string Inclusions { get; set; }
        public string Exclusion { get; set; }
        public string Highlightis { get; set; }
        public string FullDescription { get; set; }
        public float MapLong { get; set; }
        public float MapLat { get; set; }
        public float AverageRating { get; set; }
        public int MaximumPerson { get; set; }
        public int MinimumPersion { get; set; }
        public string Duration { get; set; }

    }
}
