namespace MeiaBombaBeauty.Exceptions;

public class CodigoProdutoInvalidoException : ArgumentException
{
    public CodigoProdutoInvalidoException(string mensagem)
        : base(mensagem) { }
}
