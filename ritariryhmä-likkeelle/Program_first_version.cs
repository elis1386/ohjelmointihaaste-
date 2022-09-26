namespace exercise3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kohde rivi?");
            int rivi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kohde sarake?");
            int sarake = Int32.Parse(Console.ReadLine());
            

            Console.WriteLine("Lähetetään ritariit");

            if (rivi > 8 || sarake > 8)
            {
                Console.WriteLine("Kirjoita numero ennen tai arvo 8");
            }
            else if (rivi == 8 || sarake == 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Riitari kolme kohteeseen ({rivi},{sarake - 1})");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Riitari nelja kohteeseen ({sarake},{rivi - 1})");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Riitari yksi kohteeseen ({rivi},{ritari1})");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Riitari kaksi kohteeseen ({sarake},{ritari2})");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Riitari kolme kohteeseen ({rivi},{ritari3})");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Riitari nelja kohteeseen ({sarake},{ritari4})");

            }

    
















        }
    }

}