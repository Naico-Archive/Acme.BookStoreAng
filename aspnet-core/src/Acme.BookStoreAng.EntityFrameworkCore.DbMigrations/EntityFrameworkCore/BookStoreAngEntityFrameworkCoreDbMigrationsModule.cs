using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.BookStoreAng.EntityFrameworkCore
{
    [DependsOn(
        typeof(BookStoreAngEntityFrameworkCoreModule)
        )]
    public class BookStoreAngEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BookStoreAngMigrationsDbContext>();
        }
    }
}
