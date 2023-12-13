using Microsoft.AspNetCore.Mvc;

namespace PayPocket.API.Controllers;

public class AuthenticationController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}