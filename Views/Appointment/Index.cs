using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Views.Appointment
{
    public class Index : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
