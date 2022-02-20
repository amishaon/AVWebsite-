using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
    }
}
