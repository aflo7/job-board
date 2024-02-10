using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        const string TheExample = "hello";
        ViewData["Example"] = TheExample;
        return View();
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