using System.Diagnostics;
using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _db;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        const string theString = "angel_is_gay";
        // ViewData["Example"] = TheExample;
        IEnumerable<Category> theCategories = _db.Categories;
        // Console.WriteLine(theCategories);
        ViewData["TheCategories"] = theCategories;

        return View(theCategories);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Jobs()
    {
        return View();
    }
    
    public IActionResult Companies()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}