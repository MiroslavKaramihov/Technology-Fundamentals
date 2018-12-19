using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandDbContext())
            {
                var allTasks = db.Band.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string members, double honorarium, string genre)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(members) || honorarium == 0 || string.IsNullOrEmpty(genre))
            {
                return RedirectToAction("Index");
            }

            Band bands = new Band();
            bands.Name = name;
            bands.Members = members;
            bands.Honorarium = honorarium;
            bands.Genre = genre;

            using (var db = new BandDbContext())
            {
                db.Band.Add(bands);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //TO DO
            return null;
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            //TO DO
            return null;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //TO DO
            return null;
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            //TO DO
            return null;
        }
    }
}