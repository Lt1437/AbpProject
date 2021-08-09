using Volo.Abp.Modularity;

namespace Abp.Project
{
    [DependsOn(
        typeof(ProjectApplicationModule),
        typeof(ProjectDomainTestModule)
        )]
    public class ProjectApplicationTestModule : AbpModule
    {

    }
}