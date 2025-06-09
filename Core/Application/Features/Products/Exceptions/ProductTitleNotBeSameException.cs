using Core.Application.Bases;

namespace Core.Application.Features.Products.Excerptions
{
    public class ProductTitleNotBeSameException : BaseExceptions
    {
        public ProductTitleNotBeSameException() : base("Product title cannot be the same as another product title.")
        {
        }

        public ProductTitleNotBeSameException(string message) : base(message)
        {
        }
    }
}