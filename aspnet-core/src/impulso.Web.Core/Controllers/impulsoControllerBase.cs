using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace impulso.Controllers
{
    public abstract class impulsoControllerBase: AbpController
    {
        protected impulsoControllerBase()
        {
            LocalizationSourceName = impulsoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
