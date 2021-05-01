using Volo.Abp.Settings;

namespace Acme.BookStoreAng.Settings
{
    public class BookStoreAngSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BookStoreAngSettings.MySetting1));
        }
    }
}
