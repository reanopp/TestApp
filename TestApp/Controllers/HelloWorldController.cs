using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/.  Everything preceding the word "Controller" forms the path. In this case, "HelloWorld"

       // public string Index()
        //{
            //will see this when going to http://localhost:60095/HelloWorld
            //index is default method when none is specified
            //return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View(); //no specific View was specified, so it will return the Index page in the HelloWorld folder under Views.
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            //will see this when going to http://localhost:60095/HelloWorld/Welcome
            //return "This is the Welcome action method...";
            //below line will use passed variables, url: http://localhost:60095/HelloWorld/Welcome?name=Rick&numtimes=4
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}

//route logic: /[Controller]/[ActionName]/[Parameters] 
