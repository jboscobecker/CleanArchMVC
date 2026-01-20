using CleanArchMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchMVC.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(p => p.Description)    
                   .IsRequired()
                   .HasMaxLength(200);   
            builder.Property(p => p.Price)
                   .IsRequired()
                   .HasColumnType("decimal(10,2)");   
            builder.HasOne( e=> e.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}
