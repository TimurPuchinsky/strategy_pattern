using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks;

namespace Duck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duckk[] duck = new Duckk[] { new MallardDuck(), new RedheadDuck(), new RubberDuck(), new DecoyDuck() };

            foreach (Duckk look in duck)
            {
                Console.WriteLine(look.swim());
                Console.WriteLine(look.display());
                if (look is Flyable)
                {
                    Console.WriteLine((look as Flyable).fly());

                }
                if (look is Quackable)
                {
                    Console.WriteLine((look as Quackable).quack());

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
