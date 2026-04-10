namespace MeiaBombaBeauty.Exceptions;

public class PagamentoInvalidoException : ArgumentOutOfRangeException
{
    public PagamentoInvalidoException(string mensagem)
        : base(mensagem) { }
}
