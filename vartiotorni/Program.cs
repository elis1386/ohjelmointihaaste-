namespace exercise4
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kirjoitaa X arvo: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoitaa Y arvo: ");
            int y = Int32.Parse(Console.ReadLine());

            if(y > 0 && x > 0)
            {
                Console.WriteLine("The enemy is the north east!");
            }
            if(y > 0 && x < 0)
            {
               Console.WriteLine("The enemy is the north east!"); 
            }
            if(x == 0 && y > 0)
            {
                Console.WriteLine("The enemy is the north!");
            }
            if(y == 0 && x < 0)
            {
                Console.WriteLine("The enemy is the west!");
            }
            if(y < 0 && x < 0)
            {
                Console.WriteLine("The enemy is the south west!");
            }
            if(y < 0 && x == 0)
            {
                Console.WriteLine("The enemy is the south!");
            }
            if(y < 0 && x > 0)
            {
                Console.WriteLine("The enemy is the south east!");
            }
            if(y == 0 && x > 0)
            {
                Console.WriteLine("The enemy is the east!");
            }
             if(y > 0 && x > 0)
            {
                Console.WriteLine("The enemy is the south north east!");
            }
        }
    }
}
