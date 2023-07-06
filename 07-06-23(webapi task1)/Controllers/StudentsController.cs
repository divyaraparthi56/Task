using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _07_06_23_webapi_task1_.Models;

namespace _07_06_23_webapi_task1_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        static List<string> names = new List<string>();
        //static List<Student> students = new List<Student>();
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly CollegeContext _context;

        public StudentsController(CollegeContext context)
        {
            _context = context;
        }

        /*// GET: Students
        public async Task<IActionResult> Index()
        {
              return _context.Students != null ? 
                          View(await _context.Students.ToListAsync()) :
                          Problem("Entity set 'CollegeContext.Students'  is null.");
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'CollegeContext.Students'  is null.");
            }
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
          return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Students.ToList());
        }
            //[HttpGet]
            ////}
            //public IEnumerable<string> Get([FromQuery] int n)
            //{
            //    return names;
            //}
        //    [HttpPost]
        //public IActionResult Post( string name ,Student student)
        //{
        //    students.Add(student);
        //    names.Add(name);
        //    return Ok();
        //}
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            try
            {
                _context.Add(student);
                _context.SaveChanges();
                return Ok(_context.Customers.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }


        //    [HttpPost]
        //    public IActionResult Post([FromBody] Student student)
        //    {
        //        if(student == null)
        //        {
        //            return BadRequest();

        //            try
        //            {
        //                _context.Students.Add(student);
        //                _context.SaveChanges();
        //                return Ok();

        //            }
        //            catch (Exception ex)
        //            {
        //                return BadRequest(ex.Message);  
        //            }
        //        }
        //        return Ok();
        //    }

        //}*/
        [HttpGet]
        public IActionResult Get()
        {
            /*return _context.Customers != null ? 
                        View(await _context.Customers.ToListAsync()) :
                        Problem("Entity set 'ShopContext.Customers'  is null.");*/
            return Ok(_context.Students.ToList());
        }



        [HttpPost]
        public IActionResult Post([FromBody] Student s)
        {
            if (s == null)
            {
                return BadRequest();
            }
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                return Ok(_context.Students.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }



        [HttpPut]
        public IActionResult Put(Student s)
        {
            if (s == null)
            {
                return BadRequest("student cannot be null");
            }
            //Customer customer1 = _context.Customers.FirstOrDefault(m => m.Id == id);



            if ((_context.Customers?.Any(e => e.Id == s.Id)).GetValueOrDefault())
            {
                _context.Update(s);
                _context.SaveChanges();
                return Ok(_context.Customers.ToList());
            }
            else
            {
                return NotFound("student does not exist");
            }
        }

    }
}
