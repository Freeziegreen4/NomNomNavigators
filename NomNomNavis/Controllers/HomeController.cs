using Microsoft.AspNetCore.Mvc;

namespace NomNomNavis.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
