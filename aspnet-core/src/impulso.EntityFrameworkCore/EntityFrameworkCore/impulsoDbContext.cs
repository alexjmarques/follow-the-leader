using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using impulso.Authorization.Roles;
using impulso.Authorization.Users;
using impulso.MultiTenancy;

namespace impulso.EntityFrameworkCore
{
    public class impulsoDbContext : AbpZeroDbContext<Tenant, Role, User, impulsoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public impulsoDbContext(DbContextOptions<impulsoDbContext> options)
            : base(options)
        {
        }
    }
}
