using System;

namespace App3
{
  public class Program
  {
    public static void Main(string[] args)
    {
        //1º FORMA DE FAZER
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt); // ou -> Console.WriteLine(dt.ToString());
        //Output:
        //23/09/2022 16:09:56

        // 2º FORMA DE FAZER
        Console.WriteLine(DateTime.Now.ToShortDateString());
        //Output:
        //23/09/2022

        Console.WriteLine(DateTime.Now.ToLongDateString());
        //Output:
        //sexta-feira, 23 de setembro de 2022
        
    }
  }
}