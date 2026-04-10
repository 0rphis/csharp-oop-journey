using MeiaBombaBeauty.Enums;

namespace MeiaBombaBeauty.Entities;

public class Pedido
{
    public int Id { get; private set; }
    public Comprador Comprador { get; private set; }
    public List<Produto> Produtos { get; private set; }
    public decimal Total { get; private set; }
    public DateTime Data { get; private set; }
    public TipoPagamento TipoPagamento { get; private set; }

    public Pedido(int id, Comprador comprador)
    {
        Id = id;
        Comprador = comprador;
        Produtos = new List<Produto>();
        Total = 0;
        Data = DateTime.Now;
        TipoPagamento = TipoPagamento.NaoDefinido;
    }

    public void DefinirTipoPagamento(TipoPagamento tipo)
    {
        TipoPagamento = tipo;
    }

    public void AdicionarProduto(Produto produto, int quantidade)
    {
        produto.RegistrarCompra(quantidade);
        Produtos.Add(produto);
        Total += produto.Preco * quantidade;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Pedido ID: {Id}");
        Console.WriteLine($"Data: {Data}");
        Console.WriteLine($"Comprador: {Comprador.Nome}");
        Console.WriteLine($"Tipo de Pagamento: {TipoPagamento}");
        Console.WriteLine("Produtos:");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"- {produto.Nome} ({produto.Marca}) - R${produto.Preco}");
        }
        Console.WriteLine($"Total: R${Total}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(
            "Muito orbigado por compra com a gente e escolher nossa loja! Volte sempre!"
        );
        Console.WriteLine("Faça um otimo uso dos nossos produtos e se cuide! :)");
        Console.WriteLine();
    }
}
