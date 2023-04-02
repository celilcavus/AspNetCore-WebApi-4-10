using CelilCavus.WebApi.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.WebApi.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {


            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);


            builder.Property(x => x.Price).HasColumnType("decimal(10,2)");
            builder.Property(x => x.Price).HasDefaultValue("0.00");

            builder.Property(x => x.Description).HasMaxLength(500);

            builder.Property(x => x.CategoryId).IsRequired();
        }
    }
}