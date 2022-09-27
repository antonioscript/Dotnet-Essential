using System;
//using System.Linq;
namespace App6
{
  public class Program
  {
    public static void Main(string[] args)
    {
        //Base de Dados
        var names  = new List<string>() 
        {
            "Antônio",
            "Ana",
            "Catarina",
            "Pedro",
            "Juliana",
            "João", 
            "Jhonatan" 
        };

        //Mostrando todos os nomes inclusive o de "José"
        names.Add("José");

        foreach(var i in names)
        {
          Console.WriteLine(i);
          //Output: Todos os nomes
        }

        //Pegando os nomes com menos de 6 Caracteres
        var shortNames = names.Where(n => n.Length <= 6);
        foreach(var i in shortNames)
        {
          Console.WriteLine(i);
          //Output
          //Ana
          //Pedro
          //João
        }

        //Pegando apenas o Nome "Antônio"
        var antName = names.Where(n => n == "Antônio");
        foreach(var i in antName)
        {
          Console.WriteLine(i);
          //Output
          //Antônio
        }
    }
  }
}