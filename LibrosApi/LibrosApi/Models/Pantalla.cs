using LibrosApi.Interfaces;

namespace LibrosApi.Models
{
    public class Pantalla : IObserver
    {
        public string Actualizar(float temperatura)
        {
           return $"Pantalla muestra: {temperatura}°C";
        }
    }
}
