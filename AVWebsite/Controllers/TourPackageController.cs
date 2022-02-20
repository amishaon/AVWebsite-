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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AVWebsite.Controllers
{
    public class TourPackageController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHostingEnvironment hostingEnvironment;
        public TourPackageController(AppDbContext db, IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = (from c in db.TourPackages
                          select new TourPackage
                          {
                              Id = c.Id,
                              Title = c.Title,
                              Description = c.Description,
                              Image = c.Image,
                          }).ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TourPackageVM obj)
        {
            
                var startDate = DateTime.Parse(obj.StartDate);
                var endDate = DateTime.Parse(obj.EndDate);
                string uniqueFileName = null;
                if (obj.Image != null)
                {
                    string upload = Path.Combine(hostingEnvironment.WebRootPath, "images/tourPackageImages");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + obj.Image.FileName;
                    string filePath = Path.Combine(upload, uniqueFileName);
                    obj.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                TourPackage tourPackage = new TourPackage
                {
                    Title = obj.Title,
                    Description = obj.Description,
                    Inclusion = obj.Inclusion,
                    Exclusion = obj.Exclusion,
                    Image = uniqueFileName,
                    UnitName = obj.UnitName,
                    UnitPrice = obj.UnitPrice,
                    StartDate = startDate,
                    EndDate = endDate,
                    MaximumPersion = obj.MaximumPersion,
                    MinimumPerson = obj.MinimumPerson,
                    Qty = obj.Qty,

                };
                db.TourPackages.Add(tourPackage);
                db.SaveChanges();
                return RedirectToAction("details", new { id = tourPackage.Id });
          
        }




        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = db.TourPackages.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            db.TourPackages.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {


            var obj = db.TourPackages.Find(id);
            var tourPackage = new TourPackage
            {
                Title = obj.Title,
                Description = obj.Description,
                Inclusion = obj.Inclusion,
                Exclusion = obj.Exclusion,
                Image = obj.Image,
                UnitName = obj.UnitName,
                UnitPrice = obj.UnitPrice,
                StartDate = obj.StartDate,
                EndDate = obj.EndDate,
                MaximumPersion = obj.MaximumPersion,
                MinimumPerson = obj.MinimumPerson,
                Qty = obj.Qty,

            };
            return View(tourPackage);
        }

        [HttpPost]
        public IActionResult Edit(TourPackage obj)
        {
            if (ModelState.IsValid)
            {
                var model = db.TourPackages.FirstOrDefault(x => x.Id == obj.Id);
                model.Title = obj.Title;
                model.Description = obj.Description;
                model.Inclusion = obj.Inclusion;
                model.Exclusion = obj.Exclusion;
                model.Image = obj.Image;
                model.UnitName = obj.UnitName;
                model.UnitPrice = obj.UnitPrice;
                model.StartDate = obj.StartDate;
                model.EndDate = obj.EndDate;
                model.MaximumPersion = obj.MaximumPersion;
                model.MinimumPerson = obj.MinimumPerson;
                model.Qty = obj.Qty;


                db.TourPackages.Update(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var location = db.Locations.Find(id);
            Location locationVM = new Location
            {
                Id = location.Id,
                Description = location.Description,
                Name = location.Name,
                FeatureImage = location.FeatureImage,
            };
            return View(locationVM);
        }
    }
}
