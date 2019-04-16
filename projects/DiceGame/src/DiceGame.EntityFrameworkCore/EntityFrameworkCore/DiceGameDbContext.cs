using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DiceGame.Authorization.Roles;
using DiceGame.Authorization.Users;
using DiceGame.MultiTenancy;

namespace DiceGame.EntityFrameworkCore
{
    public class DiceGameDbContext : AbpZeroDbContext<Tenant, Role, User, DiceGameDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DiceGameDbContext(DbContextOptions<DiceGameDbContext> options)
            : base(options)
        {
        }
    }
}
