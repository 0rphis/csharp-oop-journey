using System;
using System.Globalization;

namespace Produtos
{
  class Program
  {
    static void Main(string[] args)
    {
      Produto p = new Produto();

      Console.WriteLine("Entre os dados do produto");
      Console.Write("Nome: ");
      p.Nome = Console.ReadLine();
      Console.Write("Preço: ");
      p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantidade no estoque: ");
      p.Quantidade = int.Parse(Console.ReadLine());

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

      int Rqnt = int.Parse(Console.ReadLine());

      p.RemoverProdutos(Rqnt);
      Console.WriteLine();
      Console.WriteLine("Dados atualizados: " + p);



    }
  }
}