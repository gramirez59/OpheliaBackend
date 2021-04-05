using System.Threading.Tasks;
using Abp.Application.Services;
using Ophelia.Sessions.Dto;

namespace Ophelia.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
