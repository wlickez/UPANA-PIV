using LibrosApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LibrosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Login([FromBody] Usuario usuario)
        {
            if (usuario.NombreUsuario == "admin" && usuario.Contrasena == "admin123")
            {
                var token = GenerarToken(usuario.NombreUsuario);
                return Ok(new { token });
            }
            else
            {
                return Unauthorized();
            }
        }

        private string GenerarToken(string nombreUsuario)
        {
            var jwtSettings = _configuration.GetSection("Jwt");
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.GetSection("Key").Value));

            var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, nombreUsuario),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim("FechaCreacion", DateTime.Now.ToString())
            };

            var token = new JwtSecurityToken(issuer: jwtSettings.GetSection("Issuer").Value,
                                             audience: jwtSettings.GetSection("Audience").Value,
                                             claims: claims,
                                             expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("ExpireMinutes").Value)),
                                             signingCredentials: credenciales);

            return new JwtSecurityTokenHandler().WriteToken(token);
                
        }
    }    
}
