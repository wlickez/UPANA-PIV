using ObserverConsole.Interfaces;
using ObserverConsole.Models;

namespace ObserverConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IObservable observable = new Models.Observable();
            var a = new Models.Observador();
            var b = new Models.Observador2();
            observable.Suscribir(a);
            observable.Suscribir(b);

            observable.NotificarObservadores("¡Hola, Observadores!");


            observable.Suscribir(new Shute());
            //observable.Desuscribir(a);
            //observable.Desuscribir(b);

            observable.NotificarObservadores("¡Hola, Observadores! ¿Siguen ahí?");


        }
    }
}
