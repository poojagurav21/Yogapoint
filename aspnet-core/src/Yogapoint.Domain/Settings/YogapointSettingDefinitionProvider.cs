using Volo.Abp.Settings;

namespace Yogapoint.Settings;

public class YogapointSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(YogapointSettings.MySetting1));
    }
}
