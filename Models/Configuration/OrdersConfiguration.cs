using CelilCavus.WebApi.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.WebApi.Configuration
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.UserId).IsRequired();

            builder.Property(x=>x.OrderDate).IsRequired().HasDefaultValueSql("GetDate()");

            builder.Property(x=>x.Status).IsRequired();
        }
    }
}