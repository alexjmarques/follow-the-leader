using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace impulso.EntityFrameworkCore
{
    public static class impulsoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<impulsoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<impulsoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
