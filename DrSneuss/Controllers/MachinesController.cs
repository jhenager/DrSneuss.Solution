using Microsoft.AspNetCore.Mvc;
using DrSneuss.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrSneuss.Controllers
{
  public class MachinesController : Controller
  {
    private readonly DrSneussContext _db;
    public MachinesController(DrSneussContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }
    public ActionResult Create()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine, int EngineerId)
    {
      _db.Machines.Add(machine);
      if (EngineerId != 0)
      {
        _db.MachineEngineer.Add(new MachineEngineer() {EngineerId = EngineerId, MachineId = machine.MachineId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisMachine = _db.Machines
        .Include(machine => machine.Engineers)
        .ThenInclude(join => join.Engineer)
        .FirstOrDefault(machines => machines.MachineId == id);
      return View(thisMachine);
    }
  }
}