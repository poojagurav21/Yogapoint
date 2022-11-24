using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Yogapoint.Data;
using Volo.Abp.DependencyInjection;

namespace Yogapoint.EntityFrameworkCore;

public class EntityFrameworkCoreYogapointDbSchemaMigrator
    : IYogapointDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreYogapointDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the YogapointDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<YogapointDbContext>()
            .Database
            .MigrateAsync();
    }
}
