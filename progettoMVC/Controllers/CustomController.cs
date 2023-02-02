using Microsoft.AspNetCore.Mvc;

namespace progettoMVC.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string CustomAction(string msg)
        {
            return "This is my first custom action. Message: " + msg;
        }
        public IActionResult CustomPage()
        {
            ViewData["msg"] = "Messaggio del controller.";
            return View();
        }
    }
}
