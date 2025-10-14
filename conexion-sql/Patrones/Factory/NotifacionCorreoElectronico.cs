namespace Patrones.Factory
{
    public class NotificacionCorreoElectronico : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
