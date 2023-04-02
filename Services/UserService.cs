using CelilCavus.WebApi.Entites;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.WebApi.Service
{
    public class UserService : BaseService<User>
    {
        public UserService(DbContext context) : base(context)
        {
        }
    }
}