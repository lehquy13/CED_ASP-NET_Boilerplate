using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CED.Controllers
{
    /// <summary>
    /// template comments
    /// </summary>
    public abstract class CEDControllerBase: AbpController
    {
        /// <summary>
        /// template comments
        /// </summary>
        protected CEDControllerBase()
        {
            LocalizationSourceName = CEDConsts.LocalizationSourceName;
        }
        /// <summary>
        /// template comments
        /// </summary>
        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
