using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Ophelia.MultiTenancy.Dto;

namespace Ophelia.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

