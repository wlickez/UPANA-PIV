using LibrosApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibrosApi.Controllers
{

    [ApiController]
    public class LibrosController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("api/libros/getbyid/{id}")]
        public IActionResult Get(int id)
        {
            Respuesta respuesta = new Respuesta();

            ManejoJson manejoJson = new ManejoJson();

            List<Libro> libros = manejoJson.ObtenerLibros();

            if (libros.Count > 0)
            {
                Libro libro = libros.FirstOrDefault(libro => libro.Id == id);

                if (libro != null)
                {
                    respuesta.Codigo = 200;
                    respuesta.Mensajes = "Elemento obtenido correctamente";
                    respuesta.Resultado = libro;
                    return Ok(respuesta);
                }
                else
                {
                    respuesta.Codigo = 400;
                    respuesta.Mensajes = "No se encontró el elemento";
                    return NotFound(respuesta);
                }
            }
            else
            {
                respuesta.Codigo = 400;
                respuesta.Mensajes = "Error al obtener los elementos";
                return NotFound(respuesta);
            }
        }

        [HttpGet]
        [Route("api/libros/getall")]
        public IActionResult Get()
        {
            Respuesta respuesta = new Respuesta();

            ManejoJson manejoJson = new ManejoJson();

            List<Libro> libros = manejoJson.ObtenerLibros();

            if (libros.Count > 0)
            {
                respuesta.Codigo = 200;
                respuesta.Mensajes = "Elementos obtenidos correctamente";
                respuesta.Resultado = libros;
                return Ok(respuesta);
            }
            else
            {
                respuesta.Codigo = 400;
                respuesta.Mensajes = "Error al obtener los elementos";
                return NotFound(respuesta);
            }
        }

        [HttpPost]
        [Route("api/libros/post")]
        public IActionResult Post(Libro libro)
        {
            Respuesta respuesta = new Respuesta();

            ManejoJson manejoJson = new ManejoJson();

            bool insertado = manejoJson.AgregarLibro(libro);

            if (insertado == true)
            {
                respuesta.Codigo = 200;
                respuesta.Mensajes = "Elemento creado correctamente";
                respuesta.Resultado = libro;
                return Ok(respuesta);
            }
            else
            {
                respuesta.Codigo = 400;
                respuesta.Mensajes = "Error al crear el elemento";
                return NotFound(respuesta);
            }

        }
    }
}
