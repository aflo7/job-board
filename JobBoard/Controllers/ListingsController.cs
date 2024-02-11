using System.Diagnostics;
using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;
using System.Linq;

namespace BulkyBookWeb.Controllers;

public class ListingsController : Controller
{
    private readonly ILogger<ListingsController> _logger;
    private readonly ApplicationDbContext _db;

    public ListingsController(ILogger<ListingsController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    // GET
    public IActionResult All()
    {
        IEnumerable<JobListings> JobListings = _db.JobListings;
        ViewData["count"] = JobListings.Count();

        return View(JobListings);
    }
}