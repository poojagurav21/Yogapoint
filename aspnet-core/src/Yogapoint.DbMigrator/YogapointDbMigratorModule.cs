using Yogapoint.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Yogapoint.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(YogapointEntityFrameworkCoreModule),
    typeof(YogapointApplicationContractsModule)
    )]
public class YogapointDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
