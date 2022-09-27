using System;

namespace App2
{
  public class Program
  {
    public static void Main(string[] args)
    {     
        //Arrays
        string[] cars = {"Mustang", "Ford", "Fiat", "Hilux"};

        //List -> List<T>
        List<string> nomes = new List<string>() 
        {
            "Antônio Rocha",
            "Catarina Braga",
            "Jhonatan Rocha"
        };
        
        nomes.Remove("Jhonatan Rocha");

        foreach(string i in nomes)
        {
            Console.WriteLine(i);
        }

        //Output:
        //Antônio Rocha
        //Catarina Braga

    }
  }
}