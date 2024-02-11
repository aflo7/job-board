using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;
using System.Diagnostics;
using BulkyBookWeb.Data;

namespace BulkyBookWeb.Controllers;

public class CategoriesController : Controller
{
    
    private readonly ILogger<CategoriesController> _logger;
    private readonly ApplicationDbContext _db;

    public CategoriesController(ILogger<CategoriesController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    
    // GET
    public IActionResult All()
    {
        return View();
    }
    
    public IActionResult Index(int CategoryId, string CategoryName)
    {
        @ViewData["category_name"] = CategoryName;
        IEnumerable<Job> Jobs = _db.Job.Where(job => job.category_id == CategoryId);
        return View(Jobs);
    }
}