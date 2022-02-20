using System;
using System.ComponentModel.DataAnnotations;

namespace AVWebsite.Models.Tour
{
    public class WhatToExpect_Tour
    {
        [Key]
        public int Id { get; set; }
        public WhatToExpect WhatToExpect { get; set; }
        public int WhatToExpectId { get; set; }
        public Tours Tours { get; set; }
        public int ToursId { get; set; }

    }
}
