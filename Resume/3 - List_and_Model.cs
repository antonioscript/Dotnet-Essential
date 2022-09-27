using System;

namespace App3
{
  public class Program
  {
    public static void Main(string[] args)
    {
        List<User> user = new List<User>() 
        {
            new User() { Name = "Antônio Rocha", Age = 25 },
            new User() { Name = "Catarina Sophia", Age = 23 },
            new User() { Name = "Jhonatan Rocha", Age = 23 },
        };
    }
  }

  public class User
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }
}