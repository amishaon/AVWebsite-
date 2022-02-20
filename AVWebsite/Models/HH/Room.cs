using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVWebsite.Models.HH
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Inclusion { get; set; }
        public string Exclusion { get; set; }
        public string Image { get; set; }
        public float UnitPrice { get; set; }
        public string RoomSize { get; set; }
        public string Bed { get; set; }
        public DateTime EndDate { get; set; }
        public int MaximumPersion { get; set; }
        public int MinimumPerson { get; set; }
        public int Qty { get; set; }
        public Gallery Gallery { get; set; }
        [NotMapped]
        public int GalleryId { get; set; }
    }
}
