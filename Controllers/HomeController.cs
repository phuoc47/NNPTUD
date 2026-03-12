using Microsoft.AspNetCore.Mvc;

namespace NNPTUD.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
