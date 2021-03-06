using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly HairSalonContext _db;

        public ClientsController(HairSalonContext db)
        {
            _db = db;
        }
        // This separates the boilerplate from the Controller Code
        // The schmuck writing this code should not put things before these comments

        public ActionResult Index()
        {
            ViewBag.Clients = _db.Clients.ToList();
            ViewBag.Stylists = _db.Stylists.ToList();
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
            ViewBag.Stylist = _db.Stylists.FirstOrDefault(Stylist => Stylist.StylistId == thisClient.StylistId);
            return View(thisClient);
        }

        public ActionResult Edit(int id)
        {
            var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            return View(thisClient);
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            _db.Entry(client).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
            return View(thisClient);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
            _db.Clients.Remove(thisClient);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}