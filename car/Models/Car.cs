using System;
using System.Collections.Generic;

namespace Dealership.Models
{

  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Info;
    private static List<Car> _instances = new List<Car>{};

    public Car(string makeModel, int price, int miles, string info)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Info = info;
      _instances.Add(this);
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetInfo()
    {
      return Info;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (Price < maxPrice && Miles < maxMiles);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
  //   public bool NoMoney(int maxPrice, int maxMiles)
  //   {
  //     return (maxPrice < Price || maxMiles < Miles);
  //   }
  }

}
