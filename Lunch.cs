namespace UniEat
{
    public class Lunch
    {
        public DateTime DayOfTheWeek { get; set; }
        public DateTime CalenderWeek { get; set; }
        public DateTime Year { get; set; }
        public string MealA { get; set; }
        public string MealB { get; set; }
        public string MealC { get; set; }

        public Lunch(DateTime dayOfTheWeek, DateTime calenderWeek, DateTime year, string mealA, string mealB, string mealC)
        {
            DayOfTheWeek = dayOfTheWeek;
            CalenderWeek = calenderWeek;
            Year = year;
            MealA = mealA;
            MealB = mealB;
            MealC = mealC;
        }
        public void LaunchPlan()
        {
            Console.WriteLine("Wochenplan");
            Console.WriteLine("KW: " + CalenderWeek + " " + Year);
            Console.WriteLine("Montag: " + DayOfTheWeek);
            Console.WriteLine("Gericht A: " + MealA);
            Console.WriteLine("Gericht B: " + MealB);
            Console.WriteLine("Gericht C: " + MealC);
            Console.WriteLine("Dienstag: " + DayOfTheWeek.AddDays(1));
            Console.WriteLine("Gericht A: " + MealA);
            Console.WriteLine("Gericht B: " + MealB);
            Console.WriteLine("Gericht C: " + MealC);
            Console.WriteLine("Mittwoch: " + DayOfTheWeek.AddDays(2));
            Console.WriteLine("Gericht A: " + MealA);
            Console.WriteLine("Gericht B: " + MealB);
            Console.WriteLine("Gericht C: " + MealC);
            Console.WriteLine("Donnerstag: " + DayOfTheWeek.AddDays(3));
            Console.WriteLine("Gericht A: " + MealA);
            Console.WriteLine("Gericht B: " + MealB);
            Console.WriteLine("Gericht C: " + MealC);
            Console.WriteLine("Freitag: " + DayOfTheWeek.AddDays(4));
            Console.WriteLine("Gericht A: " + MealA);
            Console.WriteLine("Gericht B: " + MealB);
            Console.WriteLine("Gericht C: " + MealC);
        }

    }

}
