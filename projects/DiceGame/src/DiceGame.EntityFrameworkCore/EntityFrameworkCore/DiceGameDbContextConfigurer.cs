using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DiceGame.EntityFrameworkCore
{
    public static class DiceGameDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DiceGameDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DiceGameDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }

    //public static class DiceGameDbContextConfigurer
    //{
    //    public static void Configure(DbContextOptionsBuilder<DiceGameDbContext> builder, string connectionString)
    //    {
    //        builder.UseSqlServer(connectionString);
    //    }

    //    public static void Configure(DbContextOptionsBuilder<DiceGameDbContext> builder, DbConnection connection)
    //    {
    //        builder.UseSqlServer(connection);
    //    }
    //}
}
