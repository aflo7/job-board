using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;
using System.Diagnostics;
using BulkyBookWeb.Data;

namespace BulkyBookWeb.Controllers;

public class CompaniesController : Controller
{
    
    private readonly ILogger<CompaniesController> _logger;
    private readonly ApplicationDbContext _db;

    public CompaniesController(ILogger<CompaniesController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    // GET
    public IActionResult All()
    {
        
        IEnumerable<Companies> Companies = _db.Companies;
        @ViewData["count"] = Companies.Count();
        return View(Companies);
    }
}