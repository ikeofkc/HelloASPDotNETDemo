using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    public class RandomController : Controller
    {
        // GET /<controller>/
        [HttpGet]
        // [Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<h1>Hello World!</h1>";
            return Content(html, "text/html");
        }
    }
}