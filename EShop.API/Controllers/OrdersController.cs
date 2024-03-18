using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers;


[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<string>> Get()
    {
        string response = "Hello, World!";
        return Ok(response);
    }
}