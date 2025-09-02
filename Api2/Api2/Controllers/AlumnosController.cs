using Api2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {

        [HttpPost]
        public string PostAlumno(Alumno alumno)
        {
            return System.Text.Json.JsonSerializer.Serialize(alumno);           
        }
    }
}
