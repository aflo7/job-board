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
        IEnumerable<Category> TheCategories = _db.Categories;
        // ViewData["TheCategories"] = TheCategories;
        return View(TheCategories);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Jobs()
    {
        return View();
    }
    
    public IActionResult Job()
    {
        return View();
    }
    public IActionResult Category()
    {
        return View();
    }
    
    public IActionResult Companies()
    {
        return View();
    }
    
    public IActionResult Profile()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}