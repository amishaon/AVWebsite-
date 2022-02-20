using System;
using Microsoft.AspNetCore.Http;

namespace AVWebsite.Models.ViewModels
{
    public class LocationVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile FeatureImage { get; set; }
    }
}
