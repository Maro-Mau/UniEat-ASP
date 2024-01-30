using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniEat.Data;
using UniEat.Models;

namespace UniEat.Controllers
{
    [Authorize]
    public class UniEatAdminController : Controller
    {
        // Hier wird die Datenbank injiziert.
        private readonly ApplicationDbContext _context;

        public UniEatAdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult CreateEditDishes(int Id)
        {

            // Hier wird ein neues Gericht erstellt und/oder eines aus der Datenbank geladen, um es zu ändern.
            if (Id != 0)
            {
                // Wenn die ID nicht 0 ist, wird ein vorhandenes Gericht aus der Datenbank geladen.
                var dishFromDb = _context.DishesDatabase.SingleOrDefault(x => x.Id == Id);

                if (dishFromDb != null)
                {
                    // Wenn das Gericht gefunden wurde, werden die Daten in die View "addDishToDb" geladen, um sie zu bearbeiten.
                    return View(dishFromDb);
                }
                else
                {
                    // Wenn eine ID übergeben wurde, aber das Gericht nicht in der Datenbank existiert, wird ein NotFound-Template angezeigt.
                    return NotFound();
                }
            }

            // Wenn keine ID übergeben wurde, wird angenommen, dass ein neues Gericht angelegt wird.
            return View();
        }
        [HttpPost]
        public IActionResult addDishToDB(DishesDbModel dish)
        {
            if (dish.Owner != User.Identity.Name)
            {
                return Unauthorized();
            }
            // Hier wird dem Gericht ein Besitzer (Owner) hinzugefügt. Aktuell ist es noch der Ersteller, sollte sich jedoch auf eine Rolle ändern, z.B. Admin.
            dish.Owner = User.Identity.Name;

            if (dish.Id == 0)
            {
                // Wenn die ID 0 ist, werden die Daten von "DishesDbModel" in die Datenbank geschrieben.
                dish.CreateTime = DateTime.Now;
                _context.DishesDatabase.Add(dish);
            }
            else
            {
                // Wenn die ID nicht 0 ist, werden die Parameter in der Datenbank aktualisiert.
                dish.UpdateTime = DateTime.Now;
                _context.DishesDatabase.Update(dish);
            }

            // SaveChanges ist sehr wichtig, da es den Befehl sendet, dass alles, was zuvor passiert ist, gespeichert werden soll.
            _context.SaveChanges();

            return View("CreateEditDishes");
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
            // Hier werden nur die Gerichte angezeigt, die dem Besitzer gehören, damit er sie bearbeiten kann.
            var dishFromDB = _context.DishesDatabase.Where(x => x.Owner == User.Identity.Name).ToList();
            return View(dishFromDB);
        }
        [HttpPost]
        public IActionResult DeleteDish(int Id)
        {
            // Wenn die ID 0 ist, wird ein Fehler ausgegeben.
            if (Id == 0)
                return BadRequest();

            var dishFromDB = _context.DishesDatabase.SingleOrDefault(x => x.Id == Id);

            // Wenn das Löschen einen Datenbankfehler hat und die ID nicht mehr existiert, wird die Meldung "Not Found" zurückgegeben.
            if (dishFromDB == null)
                return NotFound();

            // Hier wird der Löschbefehl an die Datenbank gesendet.
            _context.DishesDatabase.Remove(dishFromDB);

            // Wieder GANZ wichtig: Speichern!
            _context.SaveChanges();

            return RedirectToAction("EditDish");
        }
        public IActionResult CreateEditWeeklyPlan()
        {
            return View();
        }
    }
}
