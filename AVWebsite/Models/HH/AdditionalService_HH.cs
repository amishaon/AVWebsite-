using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.HH
{
    public class AdditionalService_HH
    {
        [Key]
        public int Id { get; set; }
        public AdditionalService AdditionalService { get; set; }
        public HolidayHome HolidayHome { get; set; }
    }
}
