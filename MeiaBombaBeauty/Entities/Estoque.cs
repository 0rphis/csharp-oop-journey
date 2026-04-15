using System.Text.Json;
using MeiaBombaBeauty.Exceptions;

namespace MeiaBombaBeauty.Entities;

public class Estoque
{
    private List<Produto> produtos;

    public Estoque()
    {
        produtos = CatalogoProdutos.ObterTodos();
        CarregarEstoque();
    }

    public Produto BuscarProduto(string codigo)
    {
        var produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
        if (produto == null)
        {
            throw new CodigoProdutoInvalidoException("Produto não encontrado no estoque.");
        }
        return produto;
    }

    public IEnumerable<Produto> ListarTodos()
    {
        return produtos;
    }

    public void SalvarEstoque()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(produtos, options);
        File.WriteAllText("estoque.json", json);
    }

    public void CarregarEstoque()
    {
        if (!File.Exists("estoque.json"))
            return;
        var json = File.ReadAllText("estoque.json");
        produtos = JsonSerializer.Deserialize<List<Produto>>(json) ?? CatalogoProdutos.ObterTodos();
    }
}
