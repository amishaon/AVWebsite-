using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AVWebsite.Models;
using AVWebsite.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AVWebsite.Controllers
{
    public class AdditionalServiceController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHostingEnvironment hostingEnvironment;
        public AdditionalServiceController(AppDbContext db, IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var result = (from c in db.AdditionalServices
                          select new AdditionalService
                          {
                              Id = c.Id,
                              Name = c.Name,
                              Description = c.Description,
                              FeatureImage = c.FeatureImage,
                              Price = c.Price,
                              EndDate = c.EndDate

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
        public IActionResult Create(AdditionalServiceVM obj)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (obj.FeatureImage != null)
                {
                    string upload = Path.Combine(hostingEnvironment.WebRootPath, "images/additionalServices");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + obj.FeatureImage.FileName;
                    string filePath = Path.Combine(upload, uniqueFileName);
                    obj.FeatureImage.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                var date = Convert.ToDateTime(obj.EndDate);
                AdditionalService aService = new AdditionalService
                {
                    Name = obj.Name,
                    Description = obj.Description,
                    FeatureImage = uniqueFileName,
                    Price = obj.Price,
                    EndDate = date,
                };
                db.AdditionalServices.Add(aService);
                db.SaveChanges();
                return RedirectToAction("details", new { id = aService.Id });
            }
            return View();
        }




        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = db.AdditionalServices.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            db.AdditionalServices.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {


            var model = db.AdditionalServices.Find(id);
            var service = new AdditionalService
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                FeatureImage = model.FeatureImage,
                EndDate = model.EndDate,

            };
            return View(service);
        }

        [HttpPost]
        public IActionResult Edit(AdditionalService model)
        {
            if (ModelState.IsValid)
            {
                var pr = db.AdditionalServices.FirstOrDefault(x => x.Id == model.Id);
                pr.Name = model.Name;
                pr.Description = model.Description;
                pr.FeatureImage = model.FeatureImage;
                pr.Price = model.Price;
                pr.EndDate = model.EndDate;

                db.AdditionalServices.Update(pr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var location = db.AdditionalServices.Find(id);
            AdditionalService locationVM = new AdditionalService
            {
                Id = location.Id,
                Description = location.Description,
                Name = location.Name,
                Price = location.Price,
                EndDate = location.EndDate,
                FeatureImage = location.FeatureImage,
            };
            return View(locationVM);
        }
    }
}
