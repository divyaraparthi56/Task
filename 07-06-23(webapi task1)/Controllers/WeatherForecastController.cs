using _07_06_23_webapi_task1_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace _07_06_23_webapi_task1_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //    private static readonly string[] Summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};
        static List<string> names = new List<string>();
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ITimer1 _timer;
        
        public WeatherForecastController(ILogger<WeatherForecastController> logger, ITimer1 timer)
        {
            _timer= timer;
            _logger = logger;
        }
        //[HttpGet(template: "GetWeatherForecast")]
        //public IEnumerable<String> Get([FromQuery] int n)
        //{
        //    return names;
        //}
        //[HttpGet(Name = "GetWeatherForecast")]
        [HttpGet(template: "GetWeatherForecast")]
        public IEnumerable<String> Get([FromQuery] int n)
        {
            return names;
        }

        [HttpPost]
        public IActionResult Post( string name)
        {

            names.Add(name);
            return Ok(name);
        }
        [HttpPut]
        public IActionResult Put(string name, string newName)
        {
            if (names.Count > 0)
            {
                int index = names.FindIndex(n => n.Equals(name));
                names[index]=newName;
                
                
            }
            else
            {
                return BadRequest("name is empty");
            }
            return Ok(newName);
        }
        [HttpDelete]
        public IActionResult Delete(string name) {
            
            if(names.Count>0)
            {
                int index=names.FindIndex(n => n.Equals(name));
                if (index > 0)
                {
                    names.Remove(name);
                    return Ok("record deleted");
                }
            }
            
               // return NoContent();
                return NotFound("names is not exists in the collection");
       
    }
}}
