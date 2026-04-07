
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOs;
using Services.interfaces;
using Services.Requests;

namespace ApiProduct.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductInterface _productServices;

        public ProductController(IProductInterface productServices)
        {
            _productServices = productServices;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateAsync(ProductRequest request)
        {
            var created = await _productServices.CreateAsync(request);

            var links = new LinkDto
            {
                Rel = "self",
                Href = Url.Action(nameof(CreateAsync), new { id = created.Id }),
                Method = "POST"
            };

            created.Links.Add(links);
            return Ok(created);
        }
    }
}
