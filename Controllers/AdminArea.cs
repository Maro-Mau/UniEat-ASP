using Microsoft.AspNetCore.Mvc;

namespace UniEat.Controllers
{
    public class AdminArea : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
