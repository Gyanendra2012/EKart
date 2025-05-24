using Microsoft.AspNetCore.Mvc;

namespace EKart.Controllers
{
    public class YearLevelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
