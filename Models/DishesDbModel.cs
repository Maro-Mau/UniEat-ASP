namespace UniEat.Models   
{
    public class DishesDbModel
    {
        
        public int Id { get; set; }
        public string NameOfDish { get; set; }
        public bool Beef { get; set; }
        public bool Pork { get; set; }
        public bool Chicken { get; set; }
        public bool Veggie { get; set; }
        public bool Fish { get; set; }

    }
}
