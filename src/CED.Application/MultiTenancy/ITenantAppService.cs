using Abp.Application.Services;
using CED.MultiTenancy.Dto;

namespace CED.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

