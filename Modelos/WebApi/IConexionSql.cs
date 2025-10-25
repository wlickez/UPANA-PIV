using Modelos;

namespace WebApi
{
    public interface IConexionSql
    {
        void Insertar(string query);
        void Eliminar(string query);
        void Actualizar(string query);
        List<Alumno> Select(string query);
    }
}
