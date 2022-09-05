using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todaysdate = datetime.now.toshortdatestring();
            //return Ok(todaysdate);
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered id ={id}" + id); 
        }
    }
}
