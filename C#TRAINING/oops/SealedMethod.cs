using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TRAINING.oops
{
    public class Fruit
    {
        public virtual void Apple()
        {
            Console.WriteLine("Apple is red");
        }

    }
    public class Fruit2 : Fruit 
    {
        public sealed override void Apple()
        {
            Console.WriteLine("banana");
        }
    }

}
