using LibrosApi.Interfaces;

namespace LibrosApi.Models
{
    public class Alarma : IObserver
    {
        public string Actualizar(float temperatura)
        {
            return $"Alamar muestra: {temperatura}°C";
        }
    }
}
