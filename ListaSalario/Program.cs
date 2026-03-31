using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ListaSalario
{
  class Program
  {
    static void Main(string[] args)
    {

      List<Employee> employees = new List<Employee>();


      int N;

      Console.Write("How many employees will be registered? ");
      N = int.Parse(Console.ReadLine());

      for (int i = 1; i <= N; i++)
      {
        Console.WriteLine("Emplyoee #" + i + ":");
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          
          while (employees.Any(x => x.Id == id))
          {
            Console.WriteLine("This id already exists. Try again.");
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());
          }

          employees.Add(new Employee(name, id, salary));

        Console.WriteLine();


      }
      Console.Write("Enter the employee id that will have salary increase: ");
      int searchId = int.Parse(Console.ReadLine());
      Console.Write("Enter the percentage: ");
      double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine();

      Employee emp = employees.FirstOrDefault(x => x.SearchId(searchId));
      if (emp != null)
      {
        emp.AumentarSalario(percentage);
      }
      else
      {
        Console.WriteLine("This id does not exist.");
      }

      Console.WriteLine("Updated list of employees: ");
      foreach (Employee e in employees)
      {
        Console.WriteLine(e);
      }
    }
  }
}
