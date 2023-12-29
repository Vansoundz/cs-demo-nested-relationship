using Microsoft.AspNetCore.Mvc;
using Shopr.Models;
using Shopr.Services;

namespace Shopr.Controllers;

[ApiController]
[Route("[controller]")]
public class CartController : ControllerBase
{
    private readonly ICartService service;

    public CartController(ICartService _service)
    {
        service = _service;
    }


    [HttpGet]
    public async Task<ActionResult<List<Cart>>> Get()
    {
        var cart = await service.GetCart();
        return Ok(cart);
    }
}
