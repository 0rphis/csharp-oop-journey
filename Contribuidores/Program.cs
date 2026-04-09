using System.Globalization;
using System.Linq;

namespace Contribuidores
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;

            List<TaxPayes> list = new List<TaxPayes>();
            Console.Write("Enter the number of tax payers: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(
                        Console.ReadLine(),
                        CultureInfo.InvariantCulture
                    );
                    list.Add(new Individual(name, anualncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualncome, numberOfEmployees));
                }
                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayes tax in list)
            {
                Console.WriteLine(
                    $"{tax.Name}: $ {tax.Tax().ToString("F2", CultureInfo.InvariantCulture)}"
                );
            }

            Console.WriteLine(
                "TOTAL TAXES: $ "
                    + list.Sum(x => x.Tax()).ToString("F2", CultureInfo.InvariantCulture)
            );
        }
    }
}
