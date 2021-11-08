using Abp.Application.Services;
using impulso.MultiTenancy.Dto;

namespace impulso.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

