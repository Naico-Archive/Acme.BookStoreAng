using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStoreAng.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BookStoreAngMigrationsDbContextFactory : IDesignTimeDbContextFactory<BookStoreAngMigrationsDbContext>
    {
        public BookStoreAngMigrationsDbContext CreateDbContext(string[] args)
        {
            BookStoreAngEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BookStoreAngMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BookStoreAngMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.BookStoreAng.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
