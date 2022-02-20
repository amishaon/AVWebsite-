using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class AdditionalService_Tour
    {
        [Key]
        public int Id{ get; set; }
        public AdditionalService AdditionalService { get; set; }
        public int AdditionalServiceId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }

    }
}
