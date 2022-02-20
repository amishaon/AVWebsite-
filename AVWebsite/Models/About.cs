using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Icon { get; set; }
    }
}
