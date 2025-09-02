using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    
    [ApiController]
    public class SaludoController : ControllerBase
    {
        [Route("api/saludos/get")]
        [HttpGet]
        public async Task<IActionResult> SaludoAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/saludo");            
            var response = await client.SendAsync(request);
            var data = await response.Content.ReadAsStringAsync();
            return Ok(data);           

        }
    }
}
