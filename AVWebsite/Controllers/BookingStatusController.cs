using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AVWebsite.Models;
using Microsoft.AspNetCore.Mvc;


namespace AVWebsite.Controllers
{
    public class BookingStatusController : Controller
    {
        private readonly AppDbContext db;
        public BookingStatusController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var result = (from c in db.BookingStatuses
                          select new BookingStatus
                          {
                              Id = c.Id,
                              Name = c.Name,
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
        public IActionResult Create(BookingStatus obj)
        {
            if (ModelState.IsValid)
            {
                db.BookingStatuses.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = db.BookingStatuses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            db.BookingStatuses.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {


            var model = db.BookingStatuses.Find(id);
            var location = new BookingStatus
            {
                Name = model.Name,

            };
            return View(location);
        }

        [HttpPost]
        public IActionResult Edit(BookingStatus model)
        {
            if (ModelState.IsValid)
            {
                var pr = db.BookingStatuses.FirstOrDefault(x => x.Id == model.Id);
                pr.Name = model.Name;


                db.BookingStatuses.Update(pr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
