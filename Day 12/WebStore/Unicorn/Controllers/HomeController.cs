using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Unicorn.Models;
using System.Collections.Generic;
using Model.Student;

namespace Unicorn.Controllers;

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

    
    public IActionResult Students()
    {
        List<Student>student=new List<Student>();
        student.Add(new Student(){Firstname="sang",Lastname="sui"});
        student.Add(new Student(){Firstname="sammi",Lastname="siso"});
         student.Add(new Student(){Firstname="sooot",Lastname="rocky"});
      
        return Json(student);
    }


    public IActionResult AboutUs()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

      public IActionResult Just()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
