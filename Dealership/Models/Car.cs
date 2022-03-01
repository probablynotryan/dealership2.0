using System.Collections.Generic;

namespace CarF.Models
{
  public class Car
  {
    public string Model { get; set; }
    public string Year { get; set; }
    public string Miles { get; set; }
    public string Price { get; set; }

    private static List<Car> _ListOfCars = new List<Car> { };
    
    public Car(string model, string year, string miles, string price)
    {
      Model = model;
      Year = year;
      Miles = miles;
      Price = price;
      _ListOfCars.Add(this);
    }

    public static List<Car> GetAll()
      {
        return _ListOfCars;
      }

  }
}