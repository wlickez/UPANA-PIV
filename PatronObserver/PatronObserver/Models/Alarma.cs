using PatronObserver.Interfaces;

namespace PatronObserver.Models
{
    public class Alarma : IObservador
    {
        public string Actualizar(float temperatura)
        {
            return $"Alamar muestra: {temperatura}°C";
        }
    }
}
