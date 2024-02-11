using System.Diagnostics;
using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;
using System.Linq;

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
        IEnumerable<Category> Categories = _db.Categories;
        return View(Categories);
    }

    public IActionResult Privacy()
    {
        return View();
    }

   
    // public IActionResult Category(int CategoryId)
    // {
    //     IEnumerable<Job> Jobs = _db.Job.Where(job => job.category_id == CategoryId);
    //     return View(Jobs);
    // }
    
    
   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}