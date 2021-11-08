using System.Threading.Tasks;
using impulso.Configuration.Dto;

namespace impulso.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
