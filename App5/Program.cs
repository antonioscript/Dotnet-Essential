using System;
namespace App5
{
  public class Program
  {
    public static void Main(string[] args)
    {
        //EXPRESSÕES LAMBDAS
        var myNumbers = new List<int>() {0, 1, 1, 2, 3, 4, 5, 8, 15, 20, 22};

        var numbersOver5 = myNumbers.Where(n => n > 5);
        //Explicação após o "="
        //1 - Nos referenciamos a lista onde queremos filtrar (myNumbers)
        //2 - Utilizamos a propriedade "Where"
        //3 - Antes do "=>" temos o argumento (n)
    }
  }
}