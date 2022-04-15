using Microsoft.AspNetCore.Mvc;
using System;
namespace First_ASP
{
    public class HelloController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // will attempt to serve 
                // Views/Hello/Index.cshtml
            // or if that file isn't there:
                // Views/Shared/Index.cshtml
            // Here we assign the value "Hello World!" to the property .Example
            // Property names can be whatever you like
            ViewBag.Example = "Hello World!";
            return View();
        }

        // localhast:5000/hello
        [HttpGet("hello")]
        public RedirectToActionResult Hello()
        {
            // localhost:5000
            Console.WriteLine("Hello there, redirecting...");
            return RedirectToAction("HelloUser", new {username = "Armando", location = "Wyoming"});
        }

        // localhost:5000/users/???
        [HttpGet("users/{username}/{location}")]
        public JsonResult HelloUser(string username, string location)
        {
            var response = new {user = username, place = location};
            return Json(response);
        }
        // remember to use [HttpPost] attributes!
        // [HttpPost]
        // [Route("method")]
        // public IActionResult Method(string TextField, int NumberField)
        // {
        //     // Do something with form input
        // }
    }
}