namespace Patrones.Factory
{
    public class NotificacionMensaje : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}