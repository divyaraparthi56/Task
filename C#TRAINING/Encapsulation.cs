using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee
    {
        private string secKey;
       
        private string salaryReview;

        private string ReportData;

        public Employee()
        {
            StackRate = "10000000Rs";

        }

        public void ManagementAction()
        {
            // checking the review and updated
            ReportData = salaryReview + " Approved";
        }
        public void ExMethod()
        {
        }

        //read only property
        public string StackRate { get; }

        public string IpConfig
        {
            get => secKey;
            set => secKey = "Mr/Ms " + value;
        }
        public string SalaryReview
        {
            set => salaryReview = value;
        }
    }
}