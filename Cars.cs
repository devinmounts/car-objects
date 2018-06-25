using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _miles;
  private string _description;
  private int _price;

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetDescription(string newDescription)
  {
    _description = newDescription;
  }
  public string GetDescription()
  {
    return _description;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }


  // public Car(string automobileMakeModel, int automobileMiles, string automobileDescription = "This is a beautiful car.", int automobilePrice = 5000)
  // {
  //   MakeModel= automobileMakeModel;
  //   Miles = automobileMiles;
  //   Description = automobileDescription;
  //   Price = automobilePrice;
  // }
}


public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetMiles(7864);
    porsche.SetDescription("This is a luxury car");
    porsche.SetPrice(114991);

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetMiles(14241);
    ford.SetDescription("This is an American made car");
    ford.SetPrice(114991);

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetMiles(20000);
    lexus.SetDescription("This is really nice car");
    lexus.SetPrice(114991);

    Car mercedes = new Car();
    mercedes.SetMakeModel("Mercedes Benz CLS550");
    mercedes.SetMiles(37979);
    mercedes.SetDescription("This is really really nice car");
    mercedes.SetPrice(114991);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }
  }
}
