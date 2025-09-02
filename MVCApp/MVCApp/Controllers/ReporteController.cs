using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;


namespace MVCApp.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult Index()
        {
            List<Saludo> saludos = new List<Saludo>();

            for (int i = 1; i <= 10; i++)
            {
                Saludo saludo = new Saludo();
                saludo.Mensaje = "Hola " + i.ToString();
                saludo.Nombre = "Usuario " + i.ToString();

                saludos.Add(saludo);
            }

            return View(saludos);
        }
    }
}
