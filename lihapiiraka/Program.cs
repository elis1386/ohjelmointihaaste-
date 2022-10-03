namespace exercise9
{
    using System;
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kuinka paljon rahaa lompakossa?");
            int rahaa = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kuinka paljon maksaa lihapiiraka?");
            int lihapiiraka = Int32.Parse(Console.ReadLine());

            if(rahaa > lihapiiraka)
            {
                int result = rahaa - lihapiiraka;
                Console.WriteLine($"Ostit piiraka ja vaihtorahasi {result} euro");
            }
            else{
                Console.WriteLine("Valitettovasti ei ole tarpeksii rahaa,syödä toisen kerran");
            }
        }
    }
}
