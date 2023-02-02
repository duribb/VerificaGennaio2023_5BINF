using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcAlessandroDurigon.Controllers.Custom
{
    public class AlessandroDurigonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AlessandroDurigon(string messaggio="messaggio prova", int numRipetizioni=2)
        {
            ViewData["messaggio"] = messaggio;
            ViewData["numRipetizioni"] = numRipetizioni;
            return View();
        }
    }
}
