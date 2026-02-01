
using CleanArchMVC.Application.Products.Commands;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;
using MediatR;

namespace CleanArchMVC.Application.Products.Handlers
{
    public  class ProductCreateCommandHandler(IProductRepository productRepository) : IRequestHandler<ProductCreateCommand, Product>
    {
        private readonly IProductRepository _productRepository = productRepository;
        public async Task<Product> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Description, request.Price, request.Stock, request.Image);
            return product == null ? throw new ApplicationException("Error creating product") : await _productRepository.CreateAsync(product);
        }
    }
}
