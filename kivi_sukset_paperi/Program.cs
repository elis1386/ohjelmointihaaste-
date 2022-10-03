namespace exrcise7
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Valitse numero: Kivi = 1; Sukset = 2; Paperi = 3;");
            int userAnswer = Int32.Parse(Console.ReadLine());
            int compAnswer = new Random().Next(3);
            Console.WriteLine(compAnswer);

            if (userAnswer == compAnswer)
            {
                Console.WriteLine("Draw");
                return;
            }

            if (
                (userAnswer == 1 && compAnswer == 2) ||
                (userAnswer == 2 && compAnswer == 3) ||
                (userAnswer == 3 && compAnswer == 2)
            )
            {
                Console.WriteLine("User won!");
                return;
            }

            Console.WriteLine("Computer won!");
        }
    }
}
