using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Yogapoint;

[Dependency(ReplaceServices = true)]
public class YogapointBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Yogapoint";
}
