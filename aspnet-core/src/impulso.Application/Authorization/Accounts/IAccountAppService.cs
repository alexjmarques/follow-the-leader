using System.Threading.Tasks;
using Abp.Application.Services;
using impulso.Authorization.Accounts.Dto;

namespace impulso.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
