using Microsoft.AspNetCore.Mvc;

namespace MVC_ClinicSystem1712.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
