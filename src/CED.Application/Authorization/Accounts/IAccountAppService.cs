using System.Threading.Tasks;
using Abp.Application.Services;
using CED.Authorization.Accounts.Dto;

namespace CED.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
