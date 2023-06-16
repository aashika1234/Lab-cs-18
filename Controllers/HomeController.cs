using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DataAnnotation.Models;

namespace DataAnnotation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Employee e)
    {
        if (ModelState.IsValid == true)
        {
            ViewData["SuccessMessage"] = "<script>alert(Data has been submitted!!)</script>";
            ModelState.Clear();
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

