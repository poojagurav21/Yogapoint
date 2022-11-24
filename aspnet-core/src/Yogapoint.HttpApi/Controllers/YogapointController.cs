using Yogapoint.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Yogapoint.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class YogapointController : AbpControllerBase
{
    protected YogapointController()
    {
        LocalizationResource = typeof(YogapointResource);
    }
}
