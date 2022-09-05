using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
