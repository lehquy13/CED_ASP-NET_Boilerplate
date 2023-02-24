using System.Threading.Tasks;
using CED.Configuration.Dto;

namespace CED.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
