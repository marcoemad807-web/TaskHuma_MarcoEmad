using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var result = ProductData.Products.Select(p => new
        {
            id = p.Id,
            name = p.Name,
            price = p.Price
        });

        return Ok(result);
    }
}