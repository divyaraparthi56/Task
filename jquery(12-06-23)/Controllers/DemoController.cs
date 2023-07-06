using jquery_12_06_23_.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Ajax2.Models;

namespace jquery_12_06_23_.Controllers
{

        [Route("demo")]
        public class DemoController : Controller
        {
            [Route("")]
            [Route("index")]
            [Route("~/")]
            public IActionResult Index()
            {
                return View();
            }

            [Route("demo1")]
            public ContentResult Demo1()
            {
                return Content("Hello", "text/plain");
            }

            [Route("demo2/{#fullName}")]
            public ContentResult Demo2(string firstname, string lastname)
            {
                return Content("hey!" , "text/plain");
            }

            [Route("demo3")]
            public IActionResult Demo3()
            {
                var product = new Product()
                {
                    Id = "p01",
                    Name = "name 1",
                    Price = 123
                };
                return new JsonResult(product);
            }

            [Route("demo4")]
            public IActionResult Demo4()
            {
                var products = new List<Product>()
            {
                new Product() {
                    Id = "p01",
                    Name = "name 1",
                    Price = 123
                },
                new Product() {
                    Id = "p02",
                    Name = "name 2",
                    Price = 456
                },
                new Product() {
                    Id = "p03",
                    Name = "name 3",
                    Price = 789
                }
            };
                return new JsonResult(products);
            }

        }
    }


 