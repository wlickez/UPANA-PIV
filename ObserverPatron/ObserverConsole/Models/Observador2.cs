using ObserverConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConsole.Models
{
    internal class Observador2 : IObservador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine("Notificación recibida desde observador 2: " + mensaje);
        }
    }
}
