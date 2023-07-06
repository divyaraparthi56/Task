using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_2nums_15_06_23
{
    public class Add
    {
        int c;
        int e;
        int h;
        public int sum(int a, int b)
        {
            int c;
            checked { 
            try
            {
                 c=a + b;
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            }
            return a+b;

        }
        public int sub(int c, int d)
        {
         
            e = c - d;
            return e;
        }
        public int mul(int f,int g) 
        {
            h=f*g;
            return h;
            
        }
        public int div(int a,int b) 
        {
            c = a / b;
            return c;
        }

       
    }
}
