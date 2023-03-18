using Microsoft.AspNetCore.Mvc;

namespace TiendaOnline.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
