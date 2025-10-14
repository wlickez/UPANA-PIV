using PatronObserver.Interfaces;

namespace LibrosApi.Models
{
    public class Pantalla : IObservador
    {
        public string Actualizar(float temperatura)
        {
           return $"Pantalla muestra: {temperatura}°C";
        }
    }
}
