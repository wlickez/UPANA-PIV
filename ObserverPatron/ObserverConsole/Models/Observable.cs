using ObserverConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConsole.Models
{
    internal class Observable : Interfaces.IObservable
    {
        private List<IObservador> observadors = new List<IObservador>();
        public void Desuscribir(IObservador observador)
        {
            observadors.Remove(observador);
        }

        public void NotificarObservadores(string mensaje)
        {
            foreach (var observador in observadors)
            {
                observador.Notificar(mensaje);
            }
        }

        public void Suscribir(IObservador observador)
        {
            observadors.Add(observador);
        }
    }
}
