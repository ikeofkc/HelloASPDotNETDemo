using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    public class RandomController : Controller
    {
        // GET /<controller>/
        [HttpGet]
        [Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<h1>Hello World!</h1>";
            return Content(html, "text/html");
        }


        [HttpGet]
        [Route("random/welcome/{name?}")]
        public IActionResult Welcome(string name = "Ike")
        {
            if (name.ToLower() == "ike")    
            {
            return Content($"<h1>Test!! Your name is {name}!</h1>", "text/html");
            }
            else
            {
                return Content("<h1>You're a liar!<h1>", "text/html");
            }
                
        }
        
    }
}