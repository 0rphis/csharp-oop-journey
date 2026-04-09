using System;
using System.Linq;

namespace Matriz
{
    class Progra
    {
        static void Main(string[] args)
        {
            int[] vet1 = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int M = vet1[0];
            int N = vet1[1];

            int[,] Matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vet2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    Matriz[i, j] = int.Parse(vet2[j]);
                }
            }

            int procurar = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Matriz[i, j] == procurar)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + Matriz[i, j - 1]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Right: " + Matriz[i, j + 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + Matriz[i - 1, j]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Down: " + Matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
