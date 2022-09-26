namespace exercise3_class_version
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Ritari> ritarit = new List <Ritari>();
            
            Console.WriteLine("Kohde rivi?");
            int rivi = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kohde sarake?");
            int sarake = Int32.Parse(Console.ReadLine());

            Ritari ritari1 = new Ritari("Riitari yksi kohteeseen", rivi, sarake - 1);
            Ritari ritari2 = new Ritari("Riitari kaksi kohteeseen", rivi -1, sarake);
            Ritari ritari3 = new Ritari("Riitari kolme kohteeseen", rivi, sarake + 1);
            Ritari ritari4 = new Ritari("Riitari neöja kohteeseen", rivi + 1, sarake);

            ritarit.Add(ritari1);
            ritarit.Add(ritari2);
            ritarit.Add(ritari3);
            ritarit.Add(ritari4);
            
            foreach(Ritari ritari in ritarit)
            {
                ritari.Coordinates();
            }



        }
    }

}