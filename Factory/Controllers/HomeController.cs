using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Factory.Models;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}