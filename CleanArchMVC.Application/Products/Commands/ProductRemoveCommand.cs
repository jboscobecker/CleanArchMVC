using CleanArchMVC.Domain.Entities;
using MediatR;

namespace CleanArchMVC.Application.Products.Commands
{
    public class ProductRemoveCommand(int id ) : IRequest<Product>
    {
        public int Id { get; set; } = id;
    }
}
