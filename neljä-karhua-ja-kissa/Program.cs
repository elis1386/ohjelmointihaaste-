namespace exercise1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Montako kalaa?");
            int amount = Int32.Parse(Console.ReadLine());

            int karhu = amount / 4;
            int kissa = amount % 4;

            Console.WriteLine($"Karhua saa {karhu}");
            Console.WriteLine($"Kissa saa {kissa}");

            if(kissa > karhu)
            {
                Console.WriteLine(amount);
            }
        }
    }

}