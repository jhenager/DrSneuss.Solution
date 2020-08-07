using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using DrSneuss.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrSneuss.Controllers
{
  public class EngineersController : Controller
  {
    private readonly DrSneussContext _db;
    public EngineersController(DrSneussContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer, int MachineId)
    {
      _db.Engineers.Add(engineer);
      if (MachineId != 0)
      {
        _db.MachineEngineer.Add(new MachineEngineer() {MachineId = MachineId, EngineerId = engineer.EngineerId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}