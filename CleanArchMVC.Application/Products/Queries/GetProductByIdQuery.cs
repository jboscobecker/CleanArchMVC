
using CleanArchMVC.Domain.Entities;
using MediatR;

namespace CleanArchMVC.Application.Products.Queries
{
    public class GetProductByIdQuery(int id) :  IRequest<Product>
    {
        public int Id { get; set; } = id;
    }
}
