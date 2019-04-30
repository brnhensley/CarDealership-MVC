using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, string info)
    {
      Car theCar = new Car(makeModel, price, miles, info);
      return RedirectToAction("Index");
    }

  }
}
