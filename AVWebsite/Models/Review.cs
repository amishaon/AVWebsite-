using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }

    }
}
