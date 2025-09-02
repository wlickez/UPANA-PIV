using Api2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Buffers.Text;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        //api/files/get
        [HttpPost, Route("post")]
        public IActionResult Post(Datos dato)
        {
            try
            {
                string content = dato.Contenido;

                byte[] contentEncoded = Encoding.UTF8.GetBytes(content);
                if (!Path.HasExtension(dato.Nombre))
                    dato.Nombre += ".txt";

                using (FileStream fs = new FileStream(dato.Nombre, FileMode.Create))
                {
                    fs.Write(contentEncoded, 0, contentEncoded.Length);
                    return Ok(new { Mensaje = "Archivo creado correctamente" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }
        }


        [HttpPost, Route("postbase64")]
        public IActionResult PostBase64(string data)
        {           

            Datos datos = new Datos();
            datos.Nombre = "final.txt";
            datos.Contenido = data;
            byte[] contentEncoded = Convert.FromBase64String(datos.Contenido);
            using (FileStream fs = new FileStream(datos.Nombre, FileMode.Create))
            {
                fs.Write(contentEncoded, 0, contentEncoded.Length);
                return Ok("Archivo creado");
            }
        }

    }
}
