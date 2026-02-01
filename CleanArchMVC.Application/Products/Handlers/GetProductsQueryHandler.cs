using CleanArchMVC.Application.Products.Queries;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;
using MediatR;

namespace CleanArchMVC.Application.Products.Handlers
{
    public class GetProductsQueryHandler(IProductRepository productRepository) : IRequestHandler<GetProducsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository = productRepository;
        public async Task<IEnumerable<Product>> Handle(GetProducsQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductsAsync();   
        }
    }
}
