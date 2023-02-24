using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CED.EntityFrameworkCore
{
    public static class CEDDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CEDDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CEDDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
