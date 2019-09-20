using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920WEBGIT
{
    class Program
    {
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
            //TODO: csijjag
            Console.ReadKey();
        }
    }
}
