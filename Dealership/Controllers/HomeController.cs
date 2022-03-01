using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarF.Models;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      // List<Car> allCars = Car.GetAll();
      return View();
    }
  }
}