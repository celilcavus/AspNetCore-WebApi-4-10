using CelilCavus.WebApi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.WebApi.Service
{

    public class ProductService : BaseService<Product>
    {
        public ProductService(DbContext context) : base(context)
        {
        }
    }
}