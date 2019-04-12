using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DiceGame.MultiTenancy.Dto;

namespace DiceGame.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

