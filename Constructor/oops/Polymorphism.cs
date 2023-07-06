using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasics
{
    public class MathMethods
    {
        /// <summary>
        /// This function is to add two numbers
        /// </summary>
        /// <param name="x"> X is Integer</param>
        /// <param name="y">y Is Integer</param>
        /// <returns>Add result</returns>
        public int Add(int x, int y)
        {
            return x + y;
        }
        public string Add(float x, float y)
        {
            return (x + y).ToString();
        }
        public object Add(int x, int y, float m)
        {
            return x + y;
        }

        /// <summary>
        /// This function is to add three numbers
        /// </summary>
        /// <param name="x"> X is Integer</param>
        /// <param name="y">y Is Integer</param>
        /// <param name="z">z Is Integer</param>
        /// <returns>Add result</returns>
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    }


    public class ParentXClass
    {
        public virtual string GetName()
        {
            return "Parent";
        }
    }

    public class ChildXClass : ParentXClass
    {
        public override string GetName()
        {
            return "Child";
        }
    }
}




