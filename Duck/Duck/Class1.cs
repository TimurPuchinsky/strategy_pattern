using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duckk[] duck = new Duckk[] { new RedheadDuck() };

            foreach (Duckk look in duck)
            {
                Console.WriteLine(look.swim());
                Console.WriteLine(look.display());
            } 
            Console.ReadKey();
        }
    }
}
