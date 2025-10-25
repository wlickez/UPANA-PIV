using Microsoft.Data.SqlClient;
using Modelos;

namespace WebApi
{
    public class ConexionSql : IConexionSql
    {
        SqlConnection conexion;
        private string connectionString = "Data Source=tcp:epr-sql.database.windows.net;Initial Catalog=erp-bl;Persist Security Info=True;User ID=wlickez;Password=Pascal2020,.-;";

        public ConexionSql()
        {
            conexion = new SqlConnection(connectionString);
            conexion.Open();
        }
        public void Actualizar(string query)
        {            
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void Eliminar(string query)
        {
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void Insertar(string query)
        {
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public List<Alumno> Select(string query)
        {
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            List<Alumno> alumnos = new List<Alumno>();

            while (reader.Read())
            {
                Alumno alumno = new Alumno();
                alumno.Codigo = reader.GetInt32(0);
                alumno.Nombre = reader.GetString(1);

                alumnos.Add(alumno);
            }

            reader.Close();
            return alumnos;
        }
    }
}
