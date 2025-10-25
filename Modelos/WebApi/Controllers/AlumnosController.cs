using Microsoft.AspNetCore.Mvc;
using Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        IConexionSql _conexionSql;
        public AlumnosController(IConexionSql conexionSql)
        {
            _conexionSql = conexionSql;
        }

        // GET: api/<AlumnosController>
        [HttpGet]
        public List<Alumno> Get()
        {
            string select = "SELECT Codigo, Nombre FROM ALUMNO";
            return _conexionSql.Select(select);            
        }

        // GET api/<AlumnosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlumnosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlumnosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
