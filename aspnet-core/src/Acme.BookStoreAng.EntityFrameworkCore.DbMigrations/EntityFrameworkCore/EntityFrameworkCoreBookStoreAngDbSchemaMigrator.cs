using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStoreAng.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreAng.EntityFrameworkCore
{
    public class EntityFrameworkCoreBookStoreAngDbSchemaMigrator
        : IBookStoreAngDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBookStoreAngDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BookStoreAngMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BookStoreAngMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}