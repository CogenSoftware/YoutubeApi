using Core.Application.Features.Products.Rules;
using Core.Application.Interfaces.UnitOfWorks;
using Core.Domain.Entities;
using MediatR;

namespace Core.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _productRules;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules productRules)
        {
            _unitOfWork = unitOfWork;
            _productRules = productRules;
        }

        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Product> existingProducts = await _unitOfWork.GetReadRepository<Product>().GetAllAsync(p => p.Title == request.Title);
            await _productRules.ProductTitleNotBeSameException(existingProducts, request.Title);

            Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);
            await _unitOfWork.GetWriteRepository<Product>().AddAsync(product);
            int result = await _unitOfWork.SaveAsync();
            if (result == 0)
            {
                foreach (int categoryId in request.CategoryIds)
                    await _unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new(product.Id, categoryId));

                await _unitOfWork.SaveAsync();
            }

            return Unit.Value;
        }
    }
}