using Poc.Auth.SendGrid.Response;
using Poc.Contract.Command.TryWhatsApp.Request;

namespace Poc.Auth.SendGrid.Interfaces;

public interface ISendGridService
{
    Task<WebAPIResponse> WebAPI(CreateWebApiCommand dto);
}
