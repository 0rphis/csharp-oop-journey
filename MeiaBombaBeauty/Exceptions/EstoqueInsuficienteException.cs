namespace MeiaBombaBeauty.Exceptions;

public class EstoqueInsuficienteException : InvalidOperationException
{
    public EstoqueInsuficienteException(string mensagem)
        : base(mensagem) { }
}
