using Microsoft.AspNetCore.Mvc;

namespace Blog_App.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        
        
        return View();
    }
}