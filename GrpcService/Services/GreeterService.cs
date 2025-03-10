using Grpc.Core;
using GrpcService;

namespace GrpcService.Services;
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }

    public override Task<CalcReply> Add(CalcRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalcReply
        {
            Result = request.A + request.B
        });
    }

    public override Task<CalcReply> Sub(CalcRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalcReply
        {
            Result = request.A - request.B
        });
    }

    public override Task<CalcReply> Mul(CalcRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalcReply
        {
            Result = request.A * request.B
        });
    }

    public override Task<CalcReply> Div(CalcRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalcReply
        {
            Result = request.A / request.B
        });
    }
}
