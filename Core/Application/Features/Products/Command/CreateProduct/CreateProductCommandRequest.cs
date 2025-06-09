using MediatR;

namespace Core.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandRequest : IRequest
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public IList<int> CategoryIds { get; set; } = new List<int>();
    }
}