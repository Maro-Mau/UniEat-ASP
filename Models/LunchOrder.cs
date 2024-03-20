namespace UniEat.Models
{
    public class LunchOrder
    {
        public int Id { get; set; }
        public DateTime LunchID { get; set; }
        public string M1 { get; set; }
        public string M2 { get; set; }
        public string M3 { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public string MI1 { get; set; }
        public string MI2 { get; set; }
        public string MI3 { get; set; }
        public string DO1 { get; set; }
        public string DO2 { get; set; }
        public string DO3 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public bool Beef { get; set; }
        public bool Pork { get; set; }
        public bool Veggie { get; set; }
        public bool Chicken { get; set; }
    }
}
