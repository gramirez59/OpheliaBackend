using System.Threading.Tasks;
using Ophelia.Configuration.Dto;

namespace Ophelia.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
