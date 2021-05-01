using System.Threading.Tasks;

namespace Acme.BookStoreAng.Data
{
    public interface IBookStoreAngDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
