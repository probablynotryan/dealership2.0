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
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/addcar")]
    public ActionResult AddCar()
    {
      return View();
    }

    [HttpPost("/addcar")]
    public ActionResult Create(string model, string year, string miles, string price)
    {
      Car myCar = new Car(model, year, miles, price);
      return RedirectToAction("Index");
    }
  }
}