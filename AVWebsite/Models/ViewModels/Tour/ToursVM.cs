using System;
using System.Collections.Generic;
using AVWebsite.Models.Tour;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace AVWebsite.Models.ViewModels.Tour
{
    public class ToursVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile FeatureImage { get; set; }
        public int LocationId { get; set; }
        
        public int FeaturePrice { get; set; }
        public string FeaturePriceText { get; set; }
        public int GalleryId { get; set; }
        public string Inclusions { get; set; }
        public string Exclusion { get; set; }
        public string Highlightis { get; set; }
        public string FullDescription { get; set; }
        public float MapLong { get; set; }
        public float MapLat { get; set; }
        public float AverageRating { get; set; }
        public int MaximumPerson { get; set; }
        public int MinimumPersion { get; set; }
        public string Duration { get; set; }

        public IEnumerable<SelectListItem> LocationList { get; set; }
        public List<int> TourLocations { get; set; }
        public ICollection<Location_Tours> Location_Tour_Obj { get; set; } = new HashSet<Location_Tours>();

        public IEnumerable<SelectListItem> TourPackageList { get; set; }
        public List<int> Tourpackages { get; set; }
        public ICollection<TourPackage_Tour> TourPackage_Tour_Obj { get; set; } = new HashSet<TourPackage_Tour>();

        public IEnumerable<SelectListItem> TourTypeList { get; set; }
        public List<int> TourTypess { get; set; }
        public ICollection<TourType_Tour> TourType_Tour_Obj { get; set; } = new HashSet<TourType_Tour>();

        public IEnumerable<SelectListItem> TourCategoryList { get; set; }
        public List<int> TourCategories { get; set; }
        public ICollection<TourCategory_Tour> TourCategory_Tour_Obj { get; set; } = new HashSet<TourCategory_Tour>();

        public IEnumerable<SelectListItem> AboutList { get; set; }
        public List<int> Abouts { get; set; }
        public ICollection<About_Tour> About_Tour_Obj { get; set; } = new HashSet<About_Tour>();

        public IEnumerable<SelectListItem> WhatToExpectList { get; set; }
        public List<int> WhatToExpects { get; set; }
        public ICollection<WhatToExpect_Tour> WhatToExpect_Tour_Obj { get; set; } = new HashSet<WhatToExpect_Tour>();

        public IEnumerable<SelectListItem> AdditionalServiceList { get; set; }
        public List<int> AdditionalServices { get; set; }
        public ICollection<AdditionalService_Tour> AdditionalService_Tour_Obj { get; set; } = new HashSet<AdditionalService_Tour>();

        public IEnumerable<SelectListItem> TourFaqList { get; set; }
        public List<int> TourFaqs { get; set; }
        public ICollection<TourFaq_Tour> TourFaq_Tour_Obj { get; set; } = new HashSet<TourFaq_Tour>();
    }
}
