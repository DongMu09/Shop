using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Shop.Web
{
    [Dependency(ReplaceServices = true)]
    public class ShopBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Shop";
    }
}
