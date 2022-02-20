using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models
{
    public class BookingStatus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
