using System.Reflection.Metadata;
using System.Text.Json;
using MeiaBombaBeauty.Entities;
using MeiaBombaBeauty.Enums;
using MeiaBombaBeauty.Exceptions;

namespace MeiaBombaBeauty;

class Program
{
    static Comprador CadastrarNovoComprador(SistemaEstetica sistema)
    {
        Console.WriteLine("Digite seu nome:");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF:");
        var cpf = Console.ReadLine();

        if (sistema.BuscarComprador(cpf) != null)
        {
            Console.WriteLine("CPF já cadastrado. Buscando comprador...");
            return sistema.BuscarComprador(cpf);
        }
        else if (cpf == null || cpf.Length != 11 || !cpf.All(char.IsDigit))
        {
            Console.WriteLine("CPF inválido. O CPF deve conter exatamente 11 dígitos numéricos.");
            Console.WriteLine("Digite um CPF válido:");
            cpf = Console.ReadLine();
        }

        Console.WriteLine("Digite seu telefone:");

        var telefone = Console.ReadLine();
        if (sistema.BuscarComprador(telefone) != null)
        {
            Console.WriteLine("Telefone já cadastrado. Buscando comprador...");
            return sistema.BuscarComprador(telefone);
        }
        else if (telefone == null || telefone.Length != 11 || !telefone.All(char.IsDigit))
        {
            Console.WriteLine(
                "Telefone inválido. O telefone deve conter exatamente 11 dígitos numéricos."
            );
            Console.WriteLine("Digite um telefone válido:");
            telefone = Console.ReadLine();
        }
        Console.WriteLine("Digite seu endereço:");
        var endereco = Console.ReadLine();

        var novoComprador = new Comprador(nome, cpf, telefone, endereco);
        sistema.CadastrarComprador(novoComprador);
        sistema.SalvarCompradores();
        Console.WriteLine($"Cadastro criado! Bem-vindo, {novoComprador.Nome}!");
        Console.WriteLine();
        return novoComprador;
    }

    static void ExibirCatalogo(SistemaEstetica sistema)
    {
        Console.WriteLine("=== Catálogo de Produtos ===");
        foreach (var produto in sistema.Estoque.ListarTodos())
        {
            produto.ExibirDetalhes();
            Console.WriteLine("---------------------------");
        }
    }

    static CategoriaProduto SelecionarCategoria()
    {
        Console.WriteLine("===== Categorias =====");
        foreach (CategoriaProduto categoria in Enum.GetValues<CategoriaProduto>())
        {
            Console.WriteLine($"{(int)categoria} - {categoria}");
        }
        Console.Write("Selecione uma categoria: ");
        var opcao = int.Parse(Console.ReadLine() ?? "1");
        Console.WriteLine();
        return (CategoriaProduto)opcao;
    }

    static void ExibirPorCategoria(SistemaEstetica sistema, CategoriaProduto categoria)
    {
        var produtos = sistema
            .Estoque.ListarTodos()
            .Where(p => p.Categoria == categoria && p.Quantidade > 0)
            .ToList();

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto disponível nessa categoria!");
            return;
        }

        Console.WriteLine($"\n=== {categoria} ===");

        for (int i = 0; i < produtos.Count; i++)
        {
            var p = produtos[i];
            Console.WriteLine($"[{p.Codigo}] {p.Nome, -30} R${p.Preco, -8}");
            if ((i + 1) % 3 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(
            @"
     __  __      _         ____                  _             ____                   _         
    |  \/  | ___(_) __ _  | __ )  ___  _ __ ___ | |__   __ _  | __ )  ___  __ _ _   _| |_ _   _ 
    | |\/| |/ _ \ |/ _` | |  _ \ / _ \| '_ ` _ \| '_ \ / _` | |  _ \ / _ \/ _` | | | | __| | | |
    | |  | |  __/ | (_| | | |_) | (_) | | | | | | |_) | (_| | | |_) |  __/ (_| | |_| | |_| |_| |
    |_|  |_|\___|_|\__,_| |____/ \___/|_| |_| |_|_.__/ \__,_| |____/ \___|\__,_|\__,_|\__|\__, |
                                                                                           |___/ "
        );
        Console.ResetColor();
        Console.WriteLine("Sistema de Produtos de Beleza 💄");
        Console.WriteLine("===============================");
        Console.WriteLine();
        var sistema = new SistemaEstetica();

        try
        {
            sistema.CarregarPedido();
            Console.WriteLine("Cliente ja tem cadastro? (S/N)");
            var resposta = Console.ReadLine();
            Comprador comprador = null;

            if (resposta?.ToUpper() == "S")
            {
                Console.WriteLine("Digite seu CPF:");
                var cpf = Console.ReadLine();
                comprador = sistema.BuscarComprador(cpf);

                if (comprador == null)
                {
                    Console.WriteLine("Cliente não encontrado. Deseja se cadastrar? (S/N)");
                    if (Console.ReadLine()?.ToUpper() == "S")
                        comprador = CadastrarNovoComprador(sistema);
                    else
                        return;
                }
                Console.WriteLine($"Bem-vindo de volta, {comprador.Nome}!");
                Console.WriteLine();
            }
            else
            {
                comprador = CadastrarNovoComprador(sistema);
            }

            bool outroPedido = true;
            while (outroPedido)
            {
                var pedido = sistema.CriarPedido(comprador);

                bool adicionado = true;
                while (adicionado)
                {
                    var categoria = SelecionarCategoria();
                    ExibirPorCategoria(sistema, categoria);
                    Console.WriteLine("Digite o código do produto (ou 0 para finalizar):");
                    var codigo = Console.ReadLine();
                    Console.WriteLine();

                    if (codigo == "0")
                        break;

                    var produto = sistema.Estoque.BuscarProduto(codigo);
                    produto.ExibirDetalhes();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine();

                    Console.WriteLine("Deseja adicionar este produto ao pedido? (S/N)");
                    if (Console.ReadLine()?.ToUpper() == "S")
                    {
                        if (produto.Quantidade == 0)
                        {
                            Console.WriteLine(
                                $"Desculpe, o produto {produto.Nome} está sem estoque!"
                            );
                            continue;
                        }

                        Console.Write("Quantidade:");
                        var quantidade = int.TryParse(Console.ReadLine(), out var q) ? q : 0;

                        if (quantidade > produto.Quantidade)
                        {
                            Console.WriteLine(
                                $"Quantidade indisponível! Máximo disponível: {produto.Quantidade}"
                            );
                            Console.WriteLine(
                                "Deseja comprar a quantidade máxima disponível? (S/N)"
                            );
                            if (Console.ReadLine()?.ToUpper() == "S")
                            {
                                quantidade = produto.Quantidade;
                            }
                            else
                            {
                                Console.Write("Quantidade desejada: ");
                                quantidade = int.TryParse(Console.ReadLine(), out var w) ? w : 0;
                            }
                        }
                        pedido.AdicionarProduto(produto, quantidade);
                        Console.WriteLine("Produto adicionado ao pedido!");
                    }

                    Console.WriteLine("Deseja adicionar mais produtos? (S/N)");
                    adicionado = Console.ReadLine()?.ToUpper() == "S";
                }

                if (pedido.Produtos.Count == 0)
                {
                    Console.WriteLine("Nenhum produto adicionado. Pedido cancelado.");
                    break;
                }

                // definir pagamento
                int opcao = 0;
                while (opcao < 1 || opcao > 4)
                {
                    Console.WriteLine("Tipo de pagamento:");
                    Console.WriteLine("1 - Dinheiro");
                    Console.WriteLine("2 - Cartão Crédito");
                    Console.WriteLine("3 - Cartão Débito");
                    Console.WriteLine("4 - Pix");
                    opcao = int.TryParse(Console.ReadLine() ?? "0", out var option) ? option : 0;
                    if (opcao < 1 || opcao > 4)
                        Console.WriteLine("Opção inválida. Tente novamente.");
                }
                pedido.DefinirTipoPagamento((TipoPagamento)opcao);

                // exibir resumo
                pedido.ExibirDetalhes();

                sistema.SalvarPedido();
                sistema.Estoque.salvarEstoque();

                Console.WriteLine("Deseja fazer outro pedido? (S/N)");
                outroPedido = Console.ReadLine()?.ToUpper() == "S";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
