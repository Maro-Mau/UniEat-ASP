using Microsoft.AspNetCore.Mvc;
using UniEat.Models;

namespace UniEat.Controllers
{
    public class UniEatAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MenuList()
        {
            return View();
        }

        public IActionResult NewOrder(LunchPosting lunchPosting)
        {
            //TODO: Save the lunch order to the database
            return RedirectToAction("MenuList");
        }
    }
}
