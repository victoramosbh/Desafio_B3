namespace Api.Core.DTOs
{
    public class ErroNegocio : Exception
    {
        public ErroNegocio(string mensagem) : base(mensagem) { }
    }
}
