namespace exercise5
{

    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);
            Console.WriteLine(number);
            while (true)
            {
                Console.WriteLine("Guess a number between 1-100?");
                int answer = Int32.Parse(Console.ReadLine());

                if (answer == number)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                if (answer > number)
                {
                    Console.WriteLine($"{answer} is too high");
                }
                if (answer < number)
                {
                    Console.WriteLine($"{answer} is too low");
                }
            }

        }
    }
}
