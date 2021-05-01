using Volo.Abp.Modularity;

namespace Acme.BookStoreAng
{
    [DependsOn(
        typeof(BookStoreAngApplicationModule),
        typeof(BookStoreAngDomainTestModule)
        )]
    public class BookStoreAngApplicationTestModule : AbpModule
    {

    }
}