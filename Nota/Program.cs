using System;
using System.Globalization;

namespace Nota
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno Estudante = new Aluno();
            Console.Write("Nome do aluno: ");
            Estudante.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Estudante.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Estudante.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Estudante.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + Estudante.NotaTotal.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(Estudante.Status());

        }
    }
}
