using CleanArchMVC.Application.DTOs;

namespace CleanArchMVC.Application.Interfaces
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int id);
        Task AddAsync(ProductDTO productDto);
        Task UpdateAsync(ProductDTO productDto);
        Task RemoveAsync(int id);
    }
}
