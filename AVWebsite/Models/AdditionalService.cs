using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models
{
    public class AdditionalService
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FeatureImage { get; set; }
        public float Price { get; set; }
        public DateTime EndDate { get; set; }
    }
}
