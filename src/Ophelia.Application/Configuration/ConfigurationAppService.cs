using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Ophelia.Configuration.Dto;

namespace Ophelia.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OpheliaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
