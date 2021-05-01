using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.BookStoreAng
{
    [Dependency(ReplaceServices = true)]
    public class BookStoreAngBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BookStoreAng";
    }
}
