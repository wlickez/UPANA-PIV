using System;
using System.Data;
using Dapper;
using DapperModels;
using Microsoft.Data.SqlClient;
using Patrones.Factory;

internal class Program
{
    private static string connectionString = "Data Source=tcp:epr-sql.database.windows.net;Initial Catalog=erp-bl;Persist Security Info=True;User ID=wlickez;Password=Pascal2020,.-;Application Name=\"Azure Wlickez\"";
    private static string query = "SELECT Codigo, Nombre FROM USUARIO";
    private static void Main(string[] args)
    {

        NotificacionFactory notificacionFactory = new();
        INotificacion notificacion = notificacionFactory.GetNotificacionFactory(MedioEnvio.Whatsapp);

        notificacion.Enviar("Estoy enviando una notificacion derivado de una deteccion");

        notificacion = notificacionFactory.GetNotificacionFactory(MedioEnvio.CorreoElectronico);

        notificacion.Enviar("Otra notificacion pero ahora pore Email");

        using (var context = new EntityContext(connectionString))
        {
            List<Usuario> usuarios = context.Usuarios.ToList();

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }
        }
    }

    private void ConexionSqlServerDapper()
    {
        using var conn = new SqlConnection(connectionString);
        var usuarios = conn.Query<Usuario>(query);

        foreach (Usuario usuario in usuarios)
        {
            Console.WriteLine(usuario);
        }
    }

    private void ConexionSqlServer()
    {
        try
        {
            using (var conn = new SqlConnection(connectionString))
            {

                conn.Open();
                Console.WriteLine("Conexión exitosa a la base de datos");



                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new(cmd);
                DataTable dt = new("Usuarios");

                da.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    ;
                    Console.WriteLine($"Codigo: {item[0]} Nombre: {item[2]}");
                }

                // SqlDataReader sqlDataReader = cmd.ExecuteReader();

                // while (sqlDataReader.Read())
                // {
                //     var dupla = sqlDataReader["Codigo"];
                //     Console.WriteLine(dupla);

                // }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}