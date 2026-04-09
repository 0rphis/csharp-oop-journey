using System;
using System.Globalization;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

            /*       p.SetNome("TV 4K");
            
                  Console.WriteLine(p.GetNome());
                  Console.WriteLine(p.GetPreco());
                  Console.WriteLine(p.GetQuantidade());
                  */
            /*  Console.WriteLine("Entre os dados do produto");
              Console.Write("Nome: ");
              string nome = Console.ReadLine();
              Console.Write("Preço: ");
              double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              // se quiser da pra remover isso para n pedir a quantidade e aparecer o estoque pre programado
              Console.Write("Quantidade no estoque: ");
              int quantidade = int.Parse(Console.ReadLine());
        
              Produto p2 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 5};
        
        
              Produto p = new Produto (nome, preco);
              Console.WriteLine();
              Console.WriteLine("Dados do produto: " + p);
        
              Console.WriteLine();
              Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
              int qnt = int.Parse(Console.ReadLine());
              Console.WriteLine();
        
              p.AdicionarProdutos(qnt);
              Console.WriteLine("Dados atualizados: " + p);
        
        
              Console.WriteLine();
              Console.Write("Digite o numero de produtos a ser removido do estoque: ");
        
              int qntRemov = int.Parse(Console.ReadLine());
        
              p.RemoverProdutos(qntRemov);
              Console.WriteLine();
              Console.WriteLine("Dados atualizados: " + p);
              */
        }
    }
}
