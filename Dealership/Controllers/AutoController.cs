using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarF.Models;

namespace Dealership.Controllers
{
  public class AutoController : Controller
  {
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

    [HttpGet("/list")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
  }
}