using Microsoft.AspNetCore.Mvc;
namespace APITutorial.Controller;

public class ProductController : APIBaseController
{
    [HttpGet]
    public IActionResult Get(){
        return Ok("Get All Product");
    }
}
