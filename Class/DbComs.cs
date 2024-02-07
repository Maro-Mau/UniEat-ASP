using Microsoft.AspNetCore.Mvc;
using UniEat.Data;
using UniEat.Models;
using Microsoft.AspNetCore.Authorization;
using System.Reflection;

namespace UniEat.Class
{
    [Authorize]
    public class DbComs : Controller
    {
        private readonly ApplicationDbContext _context;

        public string? Owner { get; }

        public DbComs(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddDish(DishesDbModel dish)
        {
            

            if (dish.Id == 0)
            {
                
                dish.CreateTime = DateTime.Now;
                _context.DishesDatabase.Add(dish);
            }
            else if (dish.Owner == Owner)
            {
                dish.UpdateTime = DateTime.Now;
                _context.DishesDatabase.Update(dish);

            }

            else
            {
                return Unauthorized();
            }
            _context.SaveChanges();
            return RedirectToAction("CreateEditDishes");
        }

        public IActionResult DeleteDish(int Id)
        {


            if (Id == 0)
                return BadRequest();

            var dishFromDB = _context.DishesDatabase.SingleOrDefault(x => x.Id == Id);
            if (dishFromDB == null)
                return NotFound();
            _context.DishesDatabase.Remove(dishFromDB);


            _context.SaveChanges();
            return Ok();
        }



        public IActionResult CreateEditDishes(int Id)
        {


            if (Id != 0)
            {

                var dishFromDb = _context.DishesDatabase.SingleOrDefault(x => x.Id == Id);

                if (dishFromDb != null)
                {

                    return View(dishFromDb);
                }
                else
                {

                    return NotFound();
                }
            }
            return Ok();
        }

        internal void AddDish(DishesDbModel dish, string? name)
        {
            throw new NotImplementedException();
        }
    }
}
