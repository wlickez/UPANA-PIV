using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ClaseController : Controller
    {
        IOperaciones _operaciones;
        public ClaseController(IOperaciones operaciones)
        {
            _operaciones = operaciones;
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
