using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class RedheadDuck : Duckk, Quackable, Flyable
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
        public string quack()
        {
            return "кря кря" + this.GetType();
        }
        public string fly()
        {
            return "хлоп хлоп" + this.GetType();
        }
    }
}
