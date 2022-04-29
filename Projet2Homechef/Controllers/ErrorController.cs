using Microsoft.AspNetCore.Mvc;

namespace Projet2Homechef.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error(string message)
        {
            ViewData["message"] = message;

            return View();
        }
    }
}
