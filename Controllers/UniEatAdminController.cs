using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniEat.Class;
using UniEat.Data;
using UniEat.Models;

namespace UniEat.Controllers
{
   

    [Authorize]
    public class UniEatAdminController : Controller

    {
        // Hier wird die Datenbank injiziert.
        private readonly ApplicationDbContext _context;
        private readonly string _owner;
       

        public UniEatAdminController(ApplicationDbContext context)
        {

        
            _context = context;
        }
        
        public IActionResult CreateEditDishes(int Id)
        {
            DbComs dc = new DbComs(_context);
            dc.CreateEditDishes(Id);
            return View();

        }
        [HttpPost]
        public IActionResult AddDishToDB(DishesDbModel dish)
        {
            DbComs dc = new DbComs(_context);
            dish.Owner = User.Identity.Name;
            dc.AddDish(dish);
            return RedirectToAction("CreateEditDishes");
           
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
            if (lunchPosting.Id == 0)
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

        public IActionResult EditDish()
        {

            var dishFromDB = _context.DishesDatabase.Where(x => x.Owner == User.Identity.Name).ToList();
            return View(dishFromDB);
        }
        [HttpPost]
        public IActionResult DeleteDish(int Id)
        {
            DbComs database = new DbComs(_context);
            database.DeleteDish(Id);

            return RedirectToAction("EditDish");
        }
        public IActionResult CreateEditWeeklyPlan()
        {
            return View();
        }
        public IActionResult ListDishes(int Id)
        {
            var dishFromDb = _context.DishesDatabase.SingleOrDefault(x => x.Id == Id);
            if (dishFromDb == null)
                return NotFound();

            return View(dishFromDb);
            
        }
    }
}
