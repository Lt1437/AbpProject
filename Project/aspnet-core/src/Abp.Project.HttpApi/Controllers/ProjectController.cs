using Abp.Project.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Project.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ProjectController : AbpController
    {
        protected ProjectController()
        {
            LocalizationResource = typeof(ProjectResource);
        }
    }
}