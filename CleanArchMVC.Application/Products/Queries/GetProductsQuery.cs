
using CleanArchMVC.Domain.Entities;
using MediatR;

namespace CleanArchMVC.Application.Products.Queries
{
    public class GetProducsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
