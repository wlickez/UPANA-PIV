using Api2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] UsuarioLogin ul)
        {
            try
            {
                if (ul.User == "usr1" && ul.Password == "123")
                    return Ok(new { Mensaje = "Usuario correctamente identificado"});

                else 
                    return Unauthorized(new { Mensaje = "Usuario o contraseña incorrectos" });
            }
            catch (Exception ex)
            {
                return NotFound(new { Mensaje = ex.Message });
            }
        }
    }
}
