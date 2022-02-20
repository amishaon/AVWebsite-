using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class HHType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
    }
}
