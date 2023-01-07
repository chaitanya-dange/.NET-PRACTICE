using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;

namespace tflstore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult gallery()
    {
        return View();
    }

      public IActionResult login()
    {
        return View();
    }

       public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult Validate(string el,string pass )
    {

    //Note  , the input  name   in login and the parameter in validation name must match exactly...
    // make Welcome method in controller...

         if(el =="c@gmail.com" && 
           pass=="seed"){
             
            return Redirect("/home/Welcome");
           }

        return View();
    }
    
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
