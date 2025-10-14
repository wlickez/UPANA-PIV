namespace Patrones.Factory
{
    public class NotificacionWhatsapp : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}