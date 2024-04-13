using Microsoft.Extensions.Logging;
using poc.core.api.net8.Interface;
using Poc.Auth.SendGrid.Interfaces;
using Poc.Auth.SendGrid.Response;
using Poc.Contract.Command.TryWhatsApp.Request;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace Poc.Auth.SendGrid.Services;

public class SendGridService : ISendGridService
{
    private readonly ILogger<SendGridService> _logger;
    private readonly IRedisCacheService<WebAPIResponse> _redis;

    public SendGridService(ILogger<SendGridService> logger,
                         IRedisCacheService<WebAPIResponse> redis)
    {
        _logger = logger;
        _redis = redis;
    }

    public async Task<WebAPIResponse> WebAPI(CreateWebApiCommand dto)
    {
        var client = new SendGridClient("");
        var from = new EmailAddress("gfmaurilajob@gmail.com", "Example User");
        var subject = "Sending with SendGrid is Fun";
        var to = new EmailAddress("gfmaurila@gmail.com", "Example User");
        var plainTextContent = "and easy to do anywhere, even with C#";
        var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        var response = await client.SendEmailAsync(msg);

        throw new NotImplementedException();
    }
}
