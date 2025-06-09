using Core.Application.Features.Products.Command.CreateProduct;
using Core.Application.Features.Products.Command.DeleteProduct;
using Core.Application.Features.Products.Command.UpdateProduct;
using Core.Application.Features.Products.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}