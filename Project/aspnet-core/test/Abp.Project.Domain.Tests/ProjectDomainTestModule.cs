using Abp.Project.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Project
{
    [DependsOn(
        typeof(ProjectEntityFrameworkCoreTestModule)
        )]
    public class ProjectDomainTestModule : AbpModule
    {

    }
}