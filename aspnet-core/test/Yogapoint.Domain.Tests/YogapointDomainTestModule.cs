using Yogapoint.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Yogapoint;

[DependsOn(
    typeof(YogapointEntityFrameworkCoreTestModule)
    )]
public class YogapointDomainTestModule : AbpModule
{

}
