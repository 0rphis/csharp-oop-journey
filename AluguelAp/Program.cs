using System;

namespace AluguelAp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Alugueis[] vet = new Alugueis[10];

            int N;

            Console.Write("Quantos quartos serão alugados? ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine() ?? "";
                while (nome == "")
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine() ?? "";
                }

                Console.Write("Email: ");
                string email = Console.ReadLine() ?? "";
                while (email == "")
                {
                    Console.Write("Email: ");
                    email = Console.ReadLine() ?? "";
                }

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                while (vet[quarto] != null)
                {
                    Console.Write("Quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                }

                vet[quarto] = new Alugueis(nome, email, quarto);

                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
