using Grpc.Net.Client;
using GrpcService;
using Microsoft.AspNetCore.Mvc;

namespace GrpcClient.Controllers;

[ApiController]
[Route("[controller]")]
public class GrpcController : ControllerBase
{
    [HttpGet]
    public float Get()
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5219");
        var client = new Greeter.GreeterClient(channel);

        var reply = client.Add(new CalcRequest { A = 5, B = 10 });

        return reply.Result;
    }
}
