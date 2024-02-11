using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;
using System.Diagnostics;
using BulkyBookWeb.Data;

namespace BulkyBookWeb.Controllers;

public class CompanyController : Controller
{
    
    private readonly ILogger<CompanyController> _logger;
    private readonly ApplicationDbContext _db;

    public CompanyController(ILogger<CompanyController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    // GET
    public IActionResult Companies()
    {
        IEnumerable<Companies> Companies = _db.Companies;
        return View(Companies);
    }
}