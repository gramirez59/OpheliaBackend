using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Ophelia.Controllers
{
    public abstract class OpheliaControllerBase: AbpController
    {
        protected OpheliaControllerBase()
        {
            LocalizationSourceName = OpheliaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
