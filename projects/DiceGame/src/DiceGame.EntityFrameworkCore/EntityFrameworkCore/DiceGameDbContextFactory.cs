using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DiceGame.Configuration;
using DiceGame.Web;

namespace DiceGame.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DiceGameDbContextFactory : IDesignTimeDbContextFactory<DiceGameDbContext>
    {
        public DiceGameDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DiceGameDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DiceGameDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DiceGameConsts.ConnectionStringName));

            return new DiceGameDbContext(builder.Options);
        }
    }
}
