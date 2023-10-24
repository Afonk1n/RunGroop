using Microsoft.AspNetCore.Mvc;

namespace RunGroop.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
