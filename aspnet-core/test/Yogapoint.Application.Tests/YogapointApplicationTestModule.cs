using Volo.Abp.Modularity;

namespace Yogapoint;

[DependsOn(
    typeof(YogapointApplicationModule),
    typeof(YogapointDomainTestModule)
    )]
public class YogapointApplicationTestModule : AbpModule
{

}
