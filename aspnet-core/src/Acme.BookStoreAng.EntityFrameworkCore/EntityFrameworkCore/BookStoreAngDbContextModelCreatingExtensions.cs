using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.BookStoreAng.EntityFrameworkCore
{
    public static class BookStoreAngDbContextModelCreatingExtensions
    {
        public static void ConfigureBookStoreAng(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BookStoreAngConsts.DbTablePrefix + "YourEntities", BookStoreAngConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}