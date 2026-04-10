namespace MeiaBombaBeauty.Entities;

using System.Text.Json;

public class SistemaEstetica
{
    public Estoque Estoque { get; private set; }
    public List<Pedido> Pedidos { get; private set; }
    public List<Comprador> Compradores { get; private set; }

    private const string ArquivoCompradores = "compradores.json";

    public void SalvarCompradores()
    {
        var json = JsonSerializer.Serialize(Compradores);
        File.WriteAllText(ArquivoCompradores, json);
    }

    public void CarregarCompradores()
    {
        if (!File.Exists(ArquivoCompradores))
            return;
        var json = File.ReadAllText(ArquivoCompradores);
        Compradores = JsonSerializer.Deserialize<List<Comprador>>(json) ?? new List<Comprador>();
    }

    public void SalvarPedido()
    {
        var json = JsonSerializer.Serialize(Pedidos);
        File.WriteAllText("pedidos.json", json);
    }

    public void CarregarPedido()
    {
        if (!File.Exists("pedidos.json"))
            return;
        var json = File.ReadAllText("pedidos.json");
        Pedidos = JsonSerializer.Deserialize<List<Pedido>>(json) ?? new List<Pedido>();
    }

    public Pedido BuscarPedido(int id)
    {
        return Pedidos.FirstOrDefault(p => p.Id == id);
    }

    public SistemaEstetica()
    {
        Estoque = new Estoque();
        Pedidos = new List<Pedido>();
        Compradores = new List<Comprador>();
        CarregarCompradores();
        CarregarPedido();
    }

    public Comprador BuscarComprador(string cpf)
    {
        return Compradores.FirstOrDefault(c =>
            c.Cpf.Equals(cpf, StringComparison.OrdinalIgnoreCase)
        );
    }

    public void CadastrarComprador(Comprador comprador)
    {
        if (BuscarComprador(comprador.Cpf) != null)
            throw new Exception("Comprador já cadastrado.");
        Compradores.Add(comprador);
    }

    public Pedido CriarPedido(Comprador comprador)
    {
        int id = GerarIdUnico();
        var pedido = new Pedido(id, comprador);
        Pedidos.Add(pedido);
        return pedido;
    }

    private int GerarIdUnico()
    {
        int id;
        do
        {
            id = new Random().Next(100000, 999999);
        } while (Pedidos.Any(p => p.Id == id));
        return id;
    }

    public List<Pedido> ListarPedidosPorComprador(Comprador comprador)
    {
        return Pedidos.Where(p => p.Comprador.Cpf == comprador.Cpf).ToList();
    }
}
