using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan td1 = DateTime.Now.TimeOfDay;
            int td2 = td1.Hours;
            if (td2 >= 9 && td2 < 12)
            {
                Console.WriteLine("Good morning,guys");
            }
            if (td2 >= 12 && td2 < 15)
            {
                Console.WriteLine("Good day,guys");
            }
            if (td2 >= 15 && td2 <= 22)
            {
                Console.WriteLine("Good evening,guys");
            }
        }
    }
}
