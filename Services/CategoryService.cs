using CelilCavus.WebApi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.WebApi.Service
{
    public class CategoryService : BaseService<Category>
    {
        public CategoryService(DbContext context) : base(context)
        {
            
        }
        
    }
}