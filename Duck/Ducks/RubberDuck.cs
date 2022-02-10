using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class RubberDuck : Duckk, Quackable
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
        public string quack()
        {
            return "quack " + this.GetType();
        }
    }
}
