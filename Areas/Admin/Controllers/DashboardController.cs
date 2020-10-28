using Microsoft.AspNetCore.Mvc;



namespace QonaqWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {    

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}