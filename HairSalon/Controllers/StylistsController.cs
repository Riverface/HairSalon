using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
    public class stylistsController : Controller
    {
        private readonly HairSalonContext _db;
        public stylistsController(HairSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Stylist> model = _db.stylists.ToList();
            return View(model);
        }
        // Boilerplate Separator

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            stylist.Name = stylist.first_name + " " + stylist.last_name;
            _db.stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Stylist thisStylist = _db.stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(thisStylist);
        }
        public ActionResult Edit(int id)
        {
            var thisStylist = _db.stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(thisStylist);
        }
        [HttpPost]
        public ActionResult Edit(Stylist stylist)
        {
            stylist.Name = stylist.first_name + " " + stylist.last_name;
            _db.Entry(stylist).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisStylist = _db.stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(thisStylist);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
        var thisStylist = _db.stylists.FirstOrDefault(stylist => stylist.StylistId == id);
        _db.stylists.Remove(thisStylist);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }

    }
}