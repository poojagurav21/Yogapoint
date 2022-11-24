using System;
using System.Collections.Generic;
using System.Text;
using Yogapoint.Localization;
using Volo.Abp.Application.Services;

namespace Yogapoint;

/* Inherit your application services from this class.
 */
public abstract class YogapointAppService : ApplicationService
{
    protected YogapointAppService()
    {
        LocalizationResource = typeof(YogapointResource);
    }
}
