using Microsoft.AspNetCore.Mvc;

namespace EKart.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
