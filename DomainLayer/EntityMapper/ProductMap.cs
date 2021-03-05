using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DomainLayer.EntityMapper
{
   public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("pk_productid");

            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("id")
                   .HasColumnType("INT");
            builder.Property(x => x.ProductName)
                .HasColumnName("product_name")
                   .HasColumnType("NVARCHAR(100)")
                   .IsRequired();
            builder.Property(x => x.Price)
               .HasColumnName("price")
                  .HasColumnType("float")
                  .IsRequired();
            builder.Property(x => x.CreatedDate)
              .HasColumnName("created_date")
                 .HasColumnType("datetime");
            builder.Property(x => x.ModifiedDate)
              .HasColumnName("modified_date")
                 .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
              .HasColumnName("is_active")
                 .HasColumnType("bit");
        }
    }
}
