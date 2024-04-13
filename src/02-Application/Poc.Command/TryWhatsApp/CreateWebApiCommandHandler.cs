using Ardalis.Result;
using MediatR;
using Microsoft.Extensions.Logging;
using Poc.Auth.SendGrid.Interfaces;
using Poc.Contract.Command.TryWhatsApp.Request;

namespace Poc.Command.TryWhatsApp;

public class CreateWebApiCommandHandler : IRequestHandler<CreateWebApiCommand, Result>
{
    private readonly ILogger<CreateWebApiCommandHandler> _logger;
    private readonly ISendGridService _twilioService;
    public CreateWebApiCommandHandler(ILogger<CreateWebApiCommandHandler> logger,
                                      ISendGridService twilioService)
    {
        _logger = logger;
        _twilioService = twilioService;
    }
    public async Task<Result> Handle(CreateWebApiCommand request, CancellationToken cancellationToken)
    {
        await _twilioService.WebAPI(request);
        return Result.SuccessWithMessage("Mensagem enviada com sucesso!");
    }
}
