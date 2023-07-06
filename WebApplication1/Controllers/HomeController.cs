using Elfie.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using WebApplication1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        System.Data.SqlClient.SqlConnection _con;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _con = new System.Data.SqlClient.SqlConnection("Data Source=DRAPARTH-L-5507\\SQLEXPRESS;Initial Catalog=Employeedb;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234");
            _con.Close();
            _logger = logger;


        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Employee(Employee em)
        {

            DataSet ds=new DataSet();
            _con = new SqlConnection(CommonVariables.connString);
            SqlDataAdapter s = new SqlDataAdapter(CommonVariables.selectquery, _con);

            SqlCommand cmd = new SqlCommand(CommonVariables.insertquery, _con);
            cmd.Parameters.AddWithValue("Id", em.Id);
            cmd.Parameters.AddWithValue("@Name", em.Name);

            try
            {
                ConnectionOpen();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    ViewBag.Result = "Record Inserted Successfully";
                else
                    ViewBag.Result = "Record not Inserted ";

                CloseConnection();
            }
            catch (Exception ex)
            {

                ViewBag.Result = "Record not Inserted " + ex.Message;

            }
                return View("Employee", em);
            
        }
            private void CloseConnection()
            {
                throw new NotImplementedException();
            }

            private void ConnectionOpen()
            {
                throw new NotImplementedException();
            }

            [HttpPost]

            public IActionResult Customer()
            {
                return View();
            }
            public IActionResult Building()
            {
                return View();
            }

            public IActionResult Visitor()
            {
                return View();
            }
            public IActionResult Office()
            {
                return View();
            }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }