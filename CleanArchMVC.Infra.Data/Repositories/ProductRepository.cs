using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;
using CleanArchMVC.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Infra.Data.Repositories
{
    public class ProductRepository(ApplicationDbContext context) : IProductRepository
    {
        private readonly ApplicationDbContext _context = context;   

        public async Task<Product> CreateAsync(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
           return await _context.Products.FindAsync(id);
        }

        public async Task<Product> GetProductCategoryByIdAsync(int? id)
        {
            var Product =  await _context.Products.AsNoTracking()
                                          .Include( p => p.Category) 
                                          .SingleOrDefaultAsync(c => c.Id == id);

            return Product;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
           var products = _context.Products.AsNoTracking().ToListAsync();
           return await products;
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
