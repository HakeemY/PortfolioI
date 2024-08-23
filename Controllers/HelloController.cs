using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PortfolioI.Controllers;
public class HelloController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string Index()
    {
        return "Hello from the index";
    }

    [HttpGet("projects")] // We will go over this in more detail on the next page    

    public string Projects()
    {
        return "These are my projects";
    }

    [HttpGet("contact")] // We will go over this in more detail on the next page    

    public string Contact()
    {
        return "These are my contact";
    }


}