using LibrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using PatronObserver.Models;

namespace PatronObserver.Controllers
{
    public class TemperaturaController : Controller
    {

        public ActionResult Actualizar(float nuevaTemp)
        {
            var sensor = new Sensor();
            var pantalla = new Pantalla();
            var alarma = new Alarma();

            sensor.Suscribir(pantalla);
            sensor.Suscribir(alarma);

            sensor.CambiarTemperatura(nuevaTemp);

            return Content($"Temperatura actualizada a {nuevaTemp}°C");
        }

    }
}
