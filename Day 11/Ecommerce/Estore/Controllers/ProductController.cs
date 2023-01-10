using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Estore.Models;

using BLL;
using BOL;

namespace Estore.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager manager= new CatalogManager();
        List<Product> allProdts=manager.GetAllProducts();
        this.ViewData["product"]=allProdts;
        // see this.viewData in NOTE A: in procedure.txt

        return View();
    }

    public IActionResult Details(int id)
    {
        return View();
    }

     public IActionResult Delete(int id)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}