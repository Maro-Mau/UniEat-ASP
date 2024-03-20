using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniEat.Data;
using UniEat.Models;

namespace UniEat.Controllers
{
    [Route("api/unieat")]
    [ApiController]
    public class apiUniEat : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public apiUniEat(ApplicationDbContext context)  
        {
            _context = context;
        }

        [HttpGet("dish")]
        public IActionResult Get()
        {
            var Dishes = _context.DishesDatabase.ToArray();
            return Ok(Dishes);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var DishId = _context.DishesDatabase.SingleOrDefault(x => x.Id == id);
            if (DishId == null)
                return NotFound();
            return Ok(DishId);
        }
        [HttpPost("Create")]
        public IActionResult Post(DishesDbModel dishesDb)
        {
            if(dishesDb.Id != 0)
                return BadRequest();
           
            dishesDb.CreateTime = DateTime.Now;
            _context.DishesDatabase.Add(dishesDb);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("CreateMulti")]
        public IActionResult PostMulti(DishesDbModel dishesDb)
        {
            List<DishesDbModel> dish = new();
            var dishes = _context.DishesDatabase.ToList();
                
            //foreach (DishesDbModel in dishesDb)
            //{
            //      dish dishesDb.NameOfDish = new();
            //}


            if (dishesDb.Id != 0)
                return BadRequest();

            dishesDb.CreateTime = DateTime.Now;
            _context.DishesDatabase.Add(dishesDb);
            _context.SaveChanges();
            return Ok();
        }


        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var dishDb = _context.DishesDatabase.SingleOrDefault(x =>x.Id == id);
            if (dishDb == null)
                return NotFound();

            _context.DishesDatabase.Remove(dishDb);
            _context.SaveChanges();
            return Ok("Deletet");
        }
        [HttpPut("Edit")]
        public IActionResult Edit(DishesDbModel dishesDb)
        {

            if (dishesDb.Id == 0)
                return NotFound();
            dishesDb.UpdateTime = DateTime.Now;
            _context.DishesDatabase.Update(dishesDb);
            _context.SaveChanges();
            return Ok("Update Complete");
        }

        
       
    }
}
