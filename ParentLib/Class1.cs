using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentLib
{
    public delegate string GetComapnyNameDelegate();
    public class CompanyDetails
    {
        public event GetComapnyNameDelegate MyEvent;
        public GetComapnyNameDelegate GetCompDelegate { get; set; }

        public string Caller()
        {
            MyEvent();  
            return GetCompDelegate();
        }
    }
}
