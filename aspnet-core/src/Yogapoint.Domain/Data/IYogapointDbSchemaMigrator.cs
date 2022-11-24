using System.Threading.Tasks;

namespace Yogapoint.Data;

public interface IYogapointDbSchemaMigrator
{
    Task MigrateAsync();
}
