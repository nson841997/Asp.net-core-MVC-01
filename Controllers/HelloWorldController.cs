using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //numTimes parameter defaults to 1 if no value is passed for that parameter.
        //HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
        public IActionResult Welcome(string name, int numTimes = 1 )
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}