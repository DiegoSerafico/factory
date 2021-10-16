using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Dynamic;
using Factory.Models;
using System.Collections.Generic;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> engineers = _db.Engineers.ToList();
      List<Machine> machines = _db.Machines.ToList();
      dynamic model = new ExpandoObject();
      model.Engineers = engineers;
      model.Machines = machines;
      return View(model);
    }


  }
}