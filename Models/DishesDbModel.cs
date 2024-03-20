using System.ComponentModel.DataAnnotations;

namespace UniEat.Models
{
    public class DishesDbModel
    {
        [Key]
        public int DishId { get; set; }
        public required string NameOfDish { get; set; }
        public bool Beef { get; set; }
        public bool Pork { get; set; }
        public bool Chicken { get; set; }
        public bool Veggie { get; set; }
        public bool Fish { get; set; }
        public required string Owner { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool Soup { get; set; }


    }

}
