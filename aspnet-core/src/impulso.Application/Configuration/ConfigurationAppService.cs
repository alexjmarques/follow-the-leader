using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using impulso.Configuration.Dto;

namespace impulso.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : impulsoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
