using System.ComponentModel.DataAnnotations;

namespace UniEat.Models
{
    public class MenuList
    {
        
        public int Id { get; set; }
        //Monday
        public int MonA { get; set; }
        public int MonB { get; set; }
        public int Soupe { get; set; }
        //Tuesday
        public int TueA { get; set; }
        public int TueB { get; set; }
        public int TueC { get; set; }
        //Wednesday
        public int WedA { get; set; }
        public int WedB { get; set; }
        public int WedC { get; set;}
        //Thursday
        public int ThuA { get; set; }
        public int ThuB { get; set; }
        public int ThuC { get; set; }
        //Friday
        public int FriA { get; set; }
        public int FriB { get; set; }


    }
}
