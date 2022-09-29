using System;

namespace App1
{
  public class Car
  {
    public string model;
    public string color;
    public int year;

    public Car (string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }

    public static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "Red", 2015);
        Car Fiat = new Car("Uno", "Blue", 2010);
        Car Toyota = new Car("Honda Civic", "Black", 2020);

        //Saída
        Console.WriteLine(Ford.model + "-" + Ford.color + "-" + Ford.year);
        Console.WriteLine(Fiat.model + "-" + Fiat.color + "-" + Fiat.year);
        Console.WriteLine(Toyota.model + "-" + Toyota.color + "-" + Toyota.year);
        
        // Outputs 
        //Mustang-Red-2015
        //Uno-Blue-2010
        //Honda Civic-Black-2020

    }
  }
}