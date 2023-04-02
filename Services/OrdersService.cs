using CelilCavus.WebApi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.WebApi.Service
{

    public class OrdersService : BaseService<Orders>
    {
        public OrdersService(DbContext context) : base(context)
        {
        }
    }
}