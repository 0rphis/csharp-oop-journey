using System;
using System.Globalization;

namespace Exercicio2
{
  public class Program
  {
    static void Main(string[] args)
    {
      Funcionario f1 = new Funcionario();
      Funcionario f2 = new Funcionario();

      Console.Write("Dados do primeiro funcionario");
      Console.Write("Nome: ");
      f1.Name = Console.ReadLine();
      Console.Write("Salário: ");
      f1.Salario = f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Dados do segundo funcionario");
      Console.Write("Nome: ");
      f2.Name = Console.ReadLine();
      Console.Write("Salário: ");
      f2.Salario = f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário médio = "  + media.ToString("F2", CultureInfo.InvariantCulture));

      Console.ReadLine();

    }
  }
}
