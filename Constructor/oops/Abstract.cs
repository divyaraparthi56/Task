using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.oops
{
    public abstract class Parent
    {
        //public sealed string name { get; set; }
        public static int id  { get; set; }

        //public virtual string address { get; set; }

        /*public sealed int add(int a, int b)
        {
            return a+b;
        }*/
        public virtual decimal avg(int a ,int b) 
        {
            return (a+b/2);
        }
        public static int sub(int a,int b)
        {
            return a-b;
        }

}
    public class Child: Parent
    {
        public override decimal avg(int a, int b)
        {
            return a+b/2;
        }
    }


}
