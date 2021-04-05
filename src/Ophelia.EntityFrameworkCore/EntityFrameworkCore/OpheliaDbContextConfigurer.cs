using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ophelia.EntityFrameworkCore
{
    public static class OpheliaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OpheliaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OpheliaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
