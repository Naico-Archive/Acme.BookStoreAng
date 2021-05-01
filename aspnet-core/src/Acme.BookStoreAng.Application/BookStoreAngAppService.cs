using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStoreAng.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStoreAng
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStoreAngAppService : ApplicationService
    {
        protected BookStoreAngAppService()
        {
            LocalizationResource = typeof(BookStoreAngResource);
        }
    }
}
