using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers.V2;

[ApiController]
[ApiVersion("2.0")]
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
            price = p.Price,
            categoryName = p.Category?.Name
        });

        return Ok(result);
    }
}