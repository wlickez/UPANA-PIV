namespace Modelos
{
    public interface IConexionApi
    {
        Task<string> Peticion(string complemento, int tipo);

    }
}
