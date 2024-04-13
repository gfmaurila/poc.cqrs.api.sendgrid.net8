using Poc.Auth.SendGrid.Response;
using Poc.Contract.Command.TryWhatsApp.Request;

namespace Poc.Auth.SendGrid.Mapper;

public static class SendGridMapper
{
    public static WebAPIResponse MapTwilioMessageResponseToMessageResponse(CreateWebApiCommand request)
    {
        var response = new WebAPIResponse
        {

        };

        return response;
    }
}
