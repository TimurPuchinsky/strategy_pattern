using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class MallarDuck : Duckk
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
    }
}
