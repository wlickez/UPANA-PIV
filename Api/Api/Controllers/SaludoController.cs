using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    
    [ApiController]
    public class SaludoController : ControllerBase
    {
        IOperaciones _operaciones;
        public SaludoController(IOperaciones operaciones)
        {
                _operaciones = operaciones;
        }

        [HttpPost]
        [Route("api/saludo")]
        public IActionResult Saludo(Alumno alumno)
        {
            //alumno.Concatenacion = alumno.Edad.ToString() + " " + alumno.Nombre;
            return Ok(alumno);
        }
    }
}
