using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
