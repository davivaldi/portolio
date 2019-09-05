using Microsoft.AspNetCore.Mvc;
namespace portfolio
{

public class HomeController : Controller
{
    [HttpGet("")]

    public string Index()
    {
        return "This is my index!";
    }

    [HttpGet("/projects")]
    public string Projets()
    {
        return "These are my projects";
    }

    [HttpGet("/Contact")]
    public string Contact()
    {
        return "This is my Contact info";
    }
}


}