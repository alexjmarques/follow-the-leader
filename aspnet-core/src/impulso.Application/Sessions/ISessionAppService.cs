using System.Threading.Tasks;
using Abp.Application.Services;
using impulso.Sessions.Dto;

namespace impulso.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
