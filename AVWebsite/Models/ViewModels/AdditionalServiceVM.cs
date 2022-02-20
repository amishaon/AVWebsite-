using System;
using Microsoft.AspNetCore.Http;

namespace AVWebsite.Models.ViewModels
{
    public class AdditionalServiceVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile FeatureImage { get; set; }
        public float Price { get; set; }
        public string EndDate { get; set; }
    }
}
