using System;
using System.Collections.Generic;
using System.Text;
using Abp.Project.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Project
{
    /* Inherit your application services from this class.
     */
    public abstract class ProjectAppService : ApplicationService
    {
        protected ProjectAppService()
        {
            LocalizationResource = typeof(ProjectResource);
        }
    }
}
