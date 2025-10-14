using ObserverConsole.Interfaces;

namespace ObserverConsole.Models
{
    internal class Shute : IObservador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine("Notificación recibida desde observador shute: " + mensaje);
        }
    }
}
