using System.Threading.Tasks;
using Abp.Application.Services;
using CED.Sessions.Dto;

namespace CED.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
