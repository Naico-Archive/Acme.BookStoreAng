using Acme.BookStoreAng.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStoreAng
{
    [DependsOn(
        typeof(BookStoreAngEntityFrameworkCoreTestModule)
        )]
    public class BookStoreAngDomainTestModule : AbpModule
    {

    }
}