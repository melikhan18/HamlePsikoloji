using Microsoft.AspNetCore.Mvc;

namespace HamlePsikoloji.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet(Name = "GetString")]
        public String Get()
        {
            return "Deneme123";
        }


        [HttpPost(Name = "GetString")]
        public String Post()
        {
            return "Deneme123";
        }
    }
}
