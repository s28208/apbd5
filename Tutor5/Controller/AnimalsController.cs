using Microsoft.AspNetCore.Mvc;
using Tutor5.DataBase;

namespace Tutor5.Controller;

[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    /*[HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok();
    }
    
    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }*/
    
}