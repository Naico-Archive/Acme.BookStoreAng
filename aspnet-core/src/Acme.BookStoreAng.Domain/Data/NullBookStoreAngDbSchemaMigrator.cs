using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreAng.Data
{
    /* This is used if database provider does't define
     * IBookStoreAngDbSchemaMigrator implementation.
     */
    public class NullBookStoreAngDbSchemaMigrator : IBookStoreAngDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}