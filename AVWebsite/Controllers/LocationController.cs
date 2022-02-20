using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AVWebsite.Models;
using AVWebsite.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AVWebsite.Controllers
{
    public class LocationController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHostingEnvironment hostingEnvironment;
        public LocationController(AppDbContext db, IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var result = (from c in db.Locations
                          select new Location
                          {
                              Id = c.Id,
                              Name = c.Name,
                              Description = c.Description,
                              FeatureImage = c.FeatureImage,
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
        public IActionResult Create(LocationVM obj)
        {
            if (ModelState.IsValid) 
            {
                string uniqueFileName = null;
                if(obj.FeatureImage != null)
                {
                    string upload = Path.Combine(hostingEnvironment.WebRootPath, "images/locationImages");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + obj.FeatureImage.FileName;
                    string filePath = Path.Combine(upload, uniqueFileName);
                    obj.FeatureImage.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Location location = new Location
                {
                    Name = obj.Name,
                    Description = obj.Description,
                    FeatureImage = uniqueFileName
                };
                db.Locations.Add(location);
                db.SaveChanges();
                return RedirectToAction("details", new {id = location.Id });
            }
            return View();
        }




        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = db.Locations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            db.Locations.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {


            var model = db.Locations.Find(id);
            var location = new Location
            {
                Name = model.Name,

            };
            return View(location);
        }

        [HttpPost]
        public IActionResult Edit(Location model)
        {
            if (ModelState.IsValid)
            {
                var pr = db.Locations.FirstOrDefault(x => x.Id == model.Id);
                pr.Name = model.Name;


                db.Locations.Update(pr);
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
