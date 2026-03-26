using System;
using System.Globalization;

namespace Retangulo
{
  class Program
  {
    static void Main(string[] args)
    {
      Retangulo ret = new Retangulo();

      Console.WriteLine("Entre a largura e altura do retângulo:");

      ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine(ret);


    }
  }
}