using Acme.BookStoreAng.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStoreAng.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookStoreAngController : AbpController
    {
        protected BookStoreAngController()
        {
            LocalizationResource = typeof(BookStoreAngResource);
        }
    }
}