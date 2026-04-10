using MeiaBombaBeauty.Enums;
using MeiaBombaBeauty.Exceptions;

namespace MeiaBombaBeauty.Entities;

public class Produto
{
    public string Codigo { get; private set; }
    public string Nome { get; private set; }
    public string Marca { get; private set; }
    public CategoriaProduto Categoria { get; private set; }
    public decimal Preco { get; private set; }
    public int Quantidade { get; private set; }
    public int Compradas { get; private set; }

    public bool temEstoque() => Quantidade > 0;

    public Produto(
        string codigo,
        string nome,
        string marca,
        CategoriaProduto categoria,
        decimal preco,
        int quantidade,
        int compradas = 0
    )
    {
        if (codigo.Length != 9)
        {
            throw new CodigoProdutoInvalidoException(
                "O código do produto deve conter exatamente 9 caracteres."
            );
        }
        Codigo = codigo;

        Nome = nome;
        Marca = marca;
        Categoria = categoria;
        Preco = preco;
        Quantidade = quantidade;
        Compradas = compradas;
    }

    public void AtualizarQuantidade(int novaQuantidade)
    {
        Quantidade += novaQuantidade;
    }

    public void AtualizarPreco(decimal novoPreco)
    {
        Preco = novoPreco;
    }

    public void RegistrarCompra(int quantidadeComprada)
    {
        if (quantidadeComprada > Quantidade)
        {
            throw new EstoqueInsuficienteException("Quantidade insuficiente em estoque.");
        }
        Quantidade -= quantidadeComprada;
        Compradas += quantidadeComprada;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Compradas: {Compradas}");
    }
}
