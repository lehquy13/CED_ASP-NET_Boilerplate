using Abp.AspNetCore.Mvc.ViewComponents;

namespace CED.Web.Views
{
    public abstract class CEDViewComponent : AbpViewComponent
    {
        protected CEDViewComponent()
        {
            LocalizationSourceName = CEDConsts.LocalizationSourceName;
        }
    }
}
