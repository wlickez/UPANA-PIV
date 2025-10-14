using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConsole.Interfaces
{
    public interface IObservador
    {
        void Notificar(string mensaje);
    }

    public interface IObservable
    {
        void Suscribir(IObservador observador);
        void Desuscribir(IObservador observador);
        void NotificarObservadores(string mensaje);
    }
}
