using System.Threading.Tasks;

namespace Abp.Project.Data
{
    public interface IProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
