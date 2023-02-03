using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace Application.Common.Behaviour;

internal class PreProcessBehaviour<TRequest> : IRequestPreProcessor<TRequest> where TRequest : notnull, IRequest
{
    private readonly ILogger _logger;

    public PreProcessBehaviour(ILogger logger)
    {
        _logger = logger;
    }

    public Task Process(TRequest request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("MediatR request started. Request type: {request}", request.GetType());
        return Task.CompletedTask;
    }
}
