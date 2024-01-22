using Microsoft.AspNetCore.Mvc;
using UniEat.Models;
using System.IO;
using UniEat.Data;

namespace UniEat.Controllers
{
    public class UniEatAdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UniEatAdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult CreateDishes()
        {
            return View();
        }

        public IActionResult DishesDB(DishesDbModel dishesDb)
        {
            return RedirectToAction("CreateDisches");
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MenuList(int Id)
        {
            return View();
        }

        public IActionResult PostMenu(LunchPosting lunchPosting)
        {
            if(lunchPosting.Id == 0)
            {
            _context.LunchPostss.Add(lunchPosting);

            }
            else
            {
                _context.LunchPostss.Update(lunchPosting);

            }


            _context.SaveChanges();

            return RedirectToAction("MenuList");
        }
        
    }
}
