using Microsoft.AspNetCore.Mvc;

namespace RunGroop.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
