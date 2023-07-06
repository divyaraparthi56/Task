using Friday_task_30_06_23_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Friday_task_30_06_23_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string details = " ";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            string? nameOfFile = @"C:\Temp\divya.txt";
            FileInfo fi = new FileInfo(nameOfFile);
            List<Student> students = new List<Student>();
            using (StreamReader reader = fi.OpenText())
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    Student stu = new Student();
                    var rawData = s.Split(",");
                    stu.rollno = int.Parse(rawData[0]);
                    stu.name = rawData[1];
                    stu.mark1 = int.Parse(rawData[2]);
                    stu.mark2 = int.Parse(rawData[3]);
                    stu.total = stu.mark1 + stu.mark2;
                    students.Add(stu);



                }
            }
            return View("Index", students);
        }



        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult EditView()
        {
            return View();
        }
        public IActionResult createView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult createView(Student student)
        {
            string? nameOfFile = @"C:\Temp\divya.txt";
            FileInfo fi = new FileInfo(nameOfFile);
            //fi.AppendText(student.rollno);



            details += student.rollno + ",";
            details += student.name + ",";
            details += student.mark1 + ",";
            details += student.mark2 + ",";
            details += student.mark1 + student.mark2;
            using (StreamWriter sw = fi.AppendText())
            {
                // sw.WriteLine("student_details"); 
                sw.WriteLine(details);
            }
            return View("createView", student);
        }
        //[HttpGet]
        //public IActionResult StudentList() 
        //{
        //    string? nameOfFile = @"C:\Temp\StudentList1.txt";
        //    FileInfo fi = new FileInfo(nameOfFile);
        //    List<Student> list = new List<Student>();
        //    using(StreamReader sr= fi.OpenText())
        //    {
        //        string s = "";
        //        while((s= sr.ReadLine()) != null)
        //        {
        //            Student stu = new Student();
        //            var sd = s.Split(",");
        //        stu.name = sd[0];
        //        }



        //    }
        //    return View("StudentList",list);
        //}




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}