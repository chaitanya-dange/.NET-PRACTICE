using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Unicorn.Models;
using System.Collections.Generic;
using Model.Student;


namespace Unicorn.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

   

    [HttpGet]
    public IActionResult Login()
    {
        Console.WriteLine("in auth login page");
        return View();
    }

    [HttpPost]
     public IActionResult Login(string mail,string pass )
    {
        Console.WriteLine("in post login page");
        if(mail=="ak47@gmail.com"&& pass=="007"){
           return  RedirectToAction("Just","Home");

        }
        return View();
     }
    // If the input email and password match the hardcoded values, 
    // the user will be redirected to the "Just" action of the "Home" controller. 
    // If the input email and password do not match the hardcoded values, 
    // the user will be shown the login view again.


    
    


    

   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
