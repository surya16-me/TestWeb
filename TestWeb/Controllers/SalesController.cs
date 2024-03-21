using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
