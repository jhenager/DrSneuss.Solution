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
  }
}