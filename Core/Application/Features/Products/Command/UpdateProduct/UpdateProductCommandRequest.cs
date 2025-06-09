using MediatR;

namespace Core.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public IList<int> CategoryIds { get; set; } = new List<int>();
    }
}