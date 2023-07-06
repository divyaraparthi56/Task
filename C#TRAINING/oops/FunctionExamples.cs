using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.oops
{
    public class FunctionExamples
    {
        public int SumAndAvg(int x,int y,ref int avg)
        {
            avg=(x+y)/2;
            return x+y;
        }
    }
}
