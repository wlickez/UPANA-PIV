using LibrosApi.Interfaces;

namespace LibrosApi.Models
{
    public class Sensor
    {
        private List<IObserver> _observers = [];

        private float _temperatura;

        public void Suscribir(IObserver observer)
        {
            _observers.Add(observer);
        }   

        public void Desuscribir(IObserver observer)
        {
            _observers.Remove(observer);
        }


        private void Notificar()
        {
            foreach (var obs in _observers)
            {
                obs.Actualizar(_temperatura);
            }
        }

        public void CambiarTemperatura(float nuevaTemperatura)
        {
            _temperatura = nuevaTemperatura;
            Notificar();
        }




    }
}
