using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace MVC.Controllers
{
    public class AlumnosController : Controller
    {
        private IConexionApi _conexionApi;
        public AlumnosController(IConexionApi conexionApi)
        {
            _conexionApi = conexionApi;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _conexionApi.Peticion("Alumnos", 1);
            List<Alumno> alumnos = System.Text.Json.JsonSerializer.Deserialize<List<Alumno>>(data, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
            return View(alumnos);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Alumno alumno)
        {
            return View();
        }
    }
}
