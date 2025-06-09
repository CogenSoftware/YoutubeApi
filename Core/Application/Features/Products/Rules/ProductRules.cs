using Core.Application.Bases;
using Core.Application.Features.Products.Excerptions;
using Core.Domain.Entities;

namespace Core.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleNotBeSameException(IList<Product> products, string requestTitle)
        {
            if (products.Any(p => p.Title == requestTitle))
            {
                throw new ProductTitleNotBeSameException();
            }

            return Task.CompletedTask;
        }
    }
}