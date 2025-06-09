using Core.Application.Features.Products.Queries.GetAllProducts;
using FluentValidation;

namespace Core.Application.Features.Products.Command.CreateProduct
{
    public class GetAllProductsQueryValidator : AbstractValidator<GetAllProductsQueryRequest>
    {
        public GetAllProductsQueryValidator()
        {
        }
    }
}