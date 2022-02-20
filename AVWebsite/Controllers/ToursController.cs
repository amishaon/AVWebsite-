using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AVWebsite.Models;
using AVWebsite.Models.Tour;
using AVWebsite.Models.ViewModels.Tour;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AVWebsite.Controllers
{
    public class ToursController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHostingEnvironment hostingEnvironment;
        public ToursController(AppDbContext db, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ToursVM toursVM = new ToursVM();
            List<SelectListItem> locations = db.Locations
                .OrderBy(n => n.Name)
                .Select(n =>
                new SelectListItem
                {
                    Value = Convert.ToString(n.Id),
                    Text = n.Name
                }).ToList();
            toursVM.LocationList = locations;

            List<SelectListItem> packages = db.TourPackages
                .OrderBy(n => n.Title)
                .Select(n =>
                new SelectListItem
                {
                    Value = Convert.ToString(n.Id),
                    Text = n.Title
                }).ToList();
            toursVM.TourPackageList = packages;

            List<SelectListItem> types = db.TourTypes
                .OrderBy(n => n.Name)
                .Select(n =>
                new SelectListItem
                {
                    Value = Convert.ToString(n.Id),
                    Text = n.Name
                }).ToList();
            toursVM.TourTypeList = types;

            List<SelectListItem> categories = db.TourCategories
                .OrderBy(n => n.Name)
                .Select(n =>
                new SelectListItem
                {
                    Value = Convert.ToString(n.Id),
                    Text = n.Name
                }).ToList();
            toursVM.TourCategoryList = categories;

            List<SelectListItem> abouts = db.Abouts
               .OrderBy(n => n.Title)
               .Select(n =>
               new SelectListItem
               {
                   Value = Convert.ToString(n.Id),
                   Text = n.Title
               }).ToList();
            toursVM.AboutList = abouts;

            List<SelectListItem> expects = db.WhatToExpects
               .OrderBy(n => n.Title)
               .Select(n =>
               new SelectListItem
               {
                   Value = Convert.ToString(n.Id),
                   Text = n.Title
               }).ToList();
            toursVM.WhatToExpectList = expects;

            List<SelectListItem> services = db.AdditionalServices
               .OrderBy(n => n.Name)
               .Select(n =>
               new SelectListItem
               {
                   Value = Convert.ToString(n.Id),
                   Text = n.Name
               }).ToList();
            toursVM.AdditionalServiceList = services;

            List<SelectListItem> faq = db.TourFaqs
               .OrderBy(n => n.Title)
               .Select(n =>
               new SelectListItem
               {
                   Value = Convert.ToString(n.Id),
                   Text = n.Title
               }).ToList();
            toursVM.TourFaqList = faq;
            return View(toursVM);
        }

        [HttpPost]
        public IActionResult Create(ToursVM model)
        {
            if (ModelState.IsValid)
            {

               string uniqueFileName = null;
            if (model.FeatureImage != null)
            {
                string upload = Path.Combine(hostingEnvironment.WebRootPath, "images/TourFeatureImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FeatureImage.FileName;
                string filePath = Path.Combine(upload, uniqueFileName);
                model.FeatureImage.CopyTo(new FileStream(filePath, FileMode.Create));
            };
            

            Tours tours = new Tours
            {
                Name = model.Name,
                FeatureImage = uniqueFileName,
                LocationId = model.LocationId,
                FeaturePrice = model.FeaturePrice,
                FeaturePriceText = model.FeaturePriceText,
                FullDescription = model.FullDescription,
                Highlightis = model.Highlightis,
                Inclusions = model.Inclusions,
                Exclusion = model.Exclusion,
                GalleryId = model.GalleryId,
                MapLat = model.MapLat,
                MapLong = model.MapLong,
                MaximumPerson = model.MaximumPerson,
                MinimumPersion = model.MinimumPersion,
                Duration = model.Duration,
            };
            
            db.Tours.Add(tours);
            db.SaveChanges();

                foreach (var item in model.TourLocations)
                {
                    db.Location_Tours.Add(new Location_Tours
                    {
                        LocationId = item,
                        ToursId = tours.Id
                    });
                    
                }
                db.SaveChanges();

                foreach (var item in model.Tourpackages)
                {
                    db.TourPackage_Tours.Add(new TourPackage_Tour
                    {
                        TourPackageId = item,
                        ToursId = tours.Id
                    });

                }
                db.SaveChanges();

                foreach (var item in model.TourTypess)
                {
                    db.TourType_Tours.Add(new TourType_Tour
                    {
                        ToursId = tours.Id,
                        TourTypeId = item
                    });

                }
                db.SaveChanges();
                foreach (var item in model.TourCategories)
                {
                    db.TourCategory_Tours.Add(new TourCategory_Tour
                    {
                        TourCategoryId = item,
                        ToursId = tours.Id
                    });

                }
                
                db.SaveChanges();
                foreach (var item in model.Abouts)
                {
                    db.About_Tours.Add(new About_Tour
                    {
                        AboutId = item,
                        ToursId = tours.Id
                    });

                }
                db.SaveChanges();
                foreach (var item in model.WhatToExpects)
                {
                    db.WhatToExpect_Tours.Add(new WhatToExpect_Tour
                    {
                        WhatToExpectId = item,
                        ToursId = tours.Id
                    });

                }
                db.SaveChanges();
                foreach (var item in model.AdditionalServices)
                {
                    db.AdditionalService_Tours.Add(new AdditionalService_Tour
                    {
                        AdditionalServiceId = item,
                        ToursId = tours.Id
                    });

                }
                db.SaveChanges();
                foreach (var item in model.TourFaqs)
                {
                    db.TourFaq_Tours.Add(new TourFaq_Tour
                    {
                        TourFaqId = item,
                        ToursId = tours.Id
                    });

                }
                db.SaveChanges();
                return RedirectToAction("details", new { id = tours.Id });
            }
            return View(model);
        }
    }
}
