using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}