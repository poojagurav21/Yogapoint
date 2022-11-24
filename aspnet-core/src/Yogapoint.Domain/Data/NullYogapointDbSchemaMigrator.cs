using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Yogapoint.Data;

/* This is used if database provider does't define
 * IYogapointDbSchemaMigrator implementation.
 */
public class NullYogapointDbSchemaMigrator : IYogapointDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
