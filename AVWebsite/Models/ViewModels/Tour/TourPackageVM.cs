using System;
using Microsoft.AspNetCore.Http;

namespace AVWebsite.Models.ViewModels.Tour
{
    public class TourPackageVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Inclusion { get; set; }
        public string Exclusion { get; set; }
        public IFormFile Image { get; set; }
        public float UnitPrice { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int MaximumPersion { get; set; }
        public int MinimumPerson { get; set; }
        public int Qty { get; set; }
        public string UnitName { get; set; }
    }
}
