using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using student_20_06_2023_unit_mock_test.MathClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using student_20_06_2023_unit_mock_test;

namespace student_20_06_2023_unit_mock_test.MathClass.Tests
{
    [TestClass()]
    public class StudentTests
    {
       

        Mock<IStudent> mockStudent = new Mock<IStudent>();
        [TestMethod()]
        
        public void GetStudentsTest()
        {
            
            mockStudent.Setup(student => student.GetStudents()).Returns(GetTestData);
            List<Student> students= mockStudent.Object.GetStudents();
            var expectedOutput = GetExpectedStudents();
            Assert.AreEqual(expectedOutput.Count, students.Count);

            //Assert.Fail();
        }
        [TestMethod()]
        public void GetStudentsTest1()
        {
            Mock<IDataService> mockService = new Mock<IDataService>();
            Mock<StudentOperation> mockOperation = new Mock<StudentOperation>(mockService.Object);
            mockService.Setup(S=>S.GetStudentData()).Returns(GetTestData);
            List<Student> students= mockOperation.Object.GetStudents();
            var expectedOutput = GetExpectedStudents();
            Assert.AreEqual(expectedOutput.Count, students.Count);

        }


        private List<Student> GetExpectedStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "aa" });
            students.Add(new Student() { Id = 2, Name = "bb" });
            students.Add(new Student() { Id = 3, Name = "cc" });
            return students;
        }
        private List<Student> GetTestData()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "aa" });
            students.Add(new Student() { Id = 2, Name = "bb" });
            students.Add(new Student() { Id = 3, Name = "cc" });
            return students;
        }

    }

    
}