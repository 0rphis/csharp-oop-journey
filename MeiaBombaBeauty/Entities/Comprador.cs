namespace MeiaBombaBeauty.Entities;

public class Comprador
{
    public String Nome { get; private set; }
    public string Cpf { get; private set; }
    public String Telefone { get; private set; }
    public string Endereco { get; private set; }

    public Comprador(string nome, string cpf, string telefone, string endereco)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome não pode ser vazio.");
        if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            throw new ArgumentException("CPF deve conter exatamente 11 dígitos.");
        if (telefone.Length < 10 || telefone.Length > 11 || !telefone.All(char.IsDigit))
            throw new ArgumentException("Telefone inválido.");

        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Endereco = endereco;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, CPF: {Cpf}, Telefone: {Telefone}, Endereço: {Endereco}";
    }
}
