using System;
namespace AVWebsite.Models.Tour
{
    public class TourPackage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Inclusion { get; set; }
        public string Exclusion { get; set; }
        public string Image { get; set; }
        public float UnitPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaximumPersion { get; set; }
        public int MinimumPerson { get; set; }
        public int Qty { get; set; }
        public string UnitName { get; set; }
    }
}
