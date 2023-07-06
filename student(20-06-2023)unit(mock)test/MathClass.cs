using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_20_06_2023_unit_mock_test
{
     public class StudentOperation: IStudent
        {
            private readonly IDataService dataService1 = new DataServices();
            public StudentOperation() { }
            public StudentOperation(IDataService dataService) 
            {
                this.dataService1 = dataService;
            }

            

            public List<Student> GetStudents()
            {
                //IDataServices dataservices = new DataServices();
                var result=dataService1.GetStudentData();
                return result;
            }

            //List<student_20_06_2023_unit_mock_test.Student> IDataServices.GetStudents()
            //{
            //    return dataService1.GetStudents();
            //}
        }
    }

