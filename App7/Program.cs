using System;
using System.Linq;
namespace App7
{
  public class Program
  {
    public static void Main(string[] args)
    {
        //MÉTODO WHERE
        List<User> users = new List<User>() 
        {
            new User() { Name = "Antônio", Age = 25, City = "Carpina" },
            new User() { Name = "Catarina", Age = 23, City = "Brusque"},
            new User() { Name = "Floriano", Age = 41, City = "Recife" },
            new User() { Name = "Jhonatan", Age = 24, City = "Carpina" },
            new User() { Name = "Juliana", Age = 10, City = "Carpina" },
            new User() { Name = "Clarice", Age = 45, City = "Fortaleza" },
        };

        //Usuários com Mais de 40 anos
        var userOlds = users.Where(u => u.Age > 40);
        foreach(User velhos in userOlds)
        {
            Console.WriteLine(velhos.Name + " : " + velhos.Age);
        }

        //Usuários de Carpina
        var userCarpina = users.Where(u => u.City == "Carpina");
        foreach(User carpinense in userCarpina)
        {
            Console.WriteLine(carpinense.Name);
        }

        //MÉTODO ORDER BY

        //Ordem Crescente
        var idadeOrescente = users.OrderBy(u => u.Age).ToList(); //Sem o "ToList" também funciona
        foreach(User i in idadeOrescente)
        {
          Console.WriteLine(i.Age);
        }

        //Ordem Decrescente
        var idadeDescrescente = users.OrderByDescending(u => u.Age).ToList();
        foreach(User i in idadeDescrescente)
        {
          Console.WriteLine(i.Age);
        }

        //MÉTODO SELECT

        //Mostrando os nomes dos usuários
        var names = users.Select(u => u.Name).ToList();
        foreach(string i in names) //Perceba que ao invés de tipo "User" colocamos "string"
        {
          Console.WriteLine(i); //E aqui nós não fizemos "i.Name)
        }

        //Talvez só funcione com o Select
        var teste = users.OrderBy(u => u.Name).ToList();
        foreach(User i in teste)
        {
          Console.WriteLine(i.Name);
        }

        //MÉTODO FirstOrDefault
        var query = users.FirstOrDefault();
        Console.WriteLine(query.Name + " | " + query.Age);
    }
  }

  public class User
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
  }
}