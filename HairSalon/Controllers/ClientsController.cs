using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class clientsController : Controller
  {
    private readonly HairSalonContext _db;

    public clientsController(HairSalonContext db)
    {   
      _db = db;
    }
        // This separates the boilerplate from the Controller Code
        // The schmuck writing this code should not put things before these comments
    public ActionResult Index()
    {
      List<Client> model = _db.clients.ToList();  
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.stylists = new SelectList(_db.stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.Stylist = _db.stylists.FirstOrDefault(stylist => stylist.StylistId == thisClient.StylistId);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.Id = new SelectList(_db.stylists, "Id", "Name");
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
      var thisClient = _db.clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.clients.FirstOrDefault(client => client.ClientId == id);
      _db.clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}