using System;
using Microsoft.AspNetCore.Mvc;
namespace portfolio
{

public class HomeController : Controller
{
    [HttpGet("")]

    public IActionResult Index()
    {
        // Views/Home/Index.cshtml
        // Views/Shared/if not in  home it will look for it in the shared folder
        return View();
    }

    [HttpGet("razorFun")]
// *********************RazorFun Assignment******************************************
    public IActionResult RazorFun()
    {
        // Views/Home/Index.cshtml
        // Views/Shared/if not in  home it will look for it in the shared folder
        return View();
    }
    [HttpGet("timeDate")]
// *********************TimeDate Assignment******************************************
    public IActionResult TimeDate()
    {
        // Views/Home/Index.cshtml
        // Views/Shared/if not in  home it will look for it in the shared folder
        return View();
    }

    [HttpGet("ind")]
    public RedirectToActionResult Ind()
    {
        Console.WriteLine("redirectiong Home");
        // adding parameters to a redirct*************************************************
        // var param = New(username="david", location="Seattle");
        // return RedirectToAction("Projects",param);
        return RedirectToAction("Index");
    }
    [HttpGet("pro")]
    public RedirectToActionResult Pro()
    {
        Console.WriteLine("redirectiong to projects");
        // adding parameters to a redirct*************************************************
        // var param = New(username="david", location="Seattle");
        // return RedirectToAction("Projects",param);
        return RedirectToAction("Projects");
    }

    [HttpGet("projects")]
    public IActionResult Projects()
    {
        return View();
    }

    [HttpGet("Contact")]
    public IActionResult Contact()
    {
        return View();
    }

    [HttpGet("con")]
    public RedirectToActionResult Con()
    {
        Console.WriteLine("redirectiong to contact");
        // adding parameters to a redirct*************************************************
        // var param = New(username="david", location="Seattle");
        // return RedirectToAction("Projects",param);
        return RedirectToAction("Contact");
    }
}


}