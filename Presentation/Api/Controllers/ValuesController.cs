using Core.Application.Interfaces.UnitOfWorks;

namespace Presentation.Api.Controllers
{
    using Core.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public ValuesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync();
            return Ok(products);
        }
    }
}