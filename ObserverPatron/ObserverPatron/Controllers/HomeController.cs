using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ObserverPatron.Models;

namespace ObserverPatron.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            

        }

        public IActionResult Index()
        {
            var subject = new RegistrationSubject();
            subject.Attach(new EmailNotifier());
            subject.Attach(new Logger());

            subject.Notify("New user registered.");
            return Content("Las notificaciones fueron enviadas");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
