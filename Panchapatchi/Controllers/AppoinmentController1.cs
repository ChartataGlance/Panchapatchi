using Microsoft.AspNetCore.Mvc;

namespace Panchapatchi.Controllers
{
    public class AppoinmentController1 : Controller
    {
        public IActionResult Index()
        {
            //return View();
            string todaysDeate = DateTime.Now.ToShortDateString();
            return Ok(todaysDeate);
        }
    }
}
