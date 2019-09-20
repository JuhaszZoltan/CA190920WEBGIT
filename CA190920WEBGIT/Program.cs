using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920WEBGIT
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Szia, hogy hívnak?");
            var n = Console.ReadLine();
            Console.WriteLine($"Ó, milyen szép név azm hogy {n}!");
            Console.WriteLine($"Szerecc programozni {n}? :3");
            var v = Console.ReadLine();
            if(v.ToLower() == "igen")
            {
                Console.WriteLine("Jaj de jó, akkor mi nagtyon jó barátok leszünk!");
            }
            else
            {
                Console.WriteLine("Hát akkor bizony kabbe!");
            }
            Console.WriteLine("nesze itt van 100 csillag:");
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
