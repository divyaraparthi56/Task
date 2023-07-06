using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace UserService.Controllers
{

   [ApiController]
   [Route("api/[controller]")]
    //[Authorize]
    public class ValuesController : Controller
    {
        public string GetToken()
        {
            var role = this.User.Claims.ToList().First();
            return DateTime.Now.ToString();
        }
    }
}
