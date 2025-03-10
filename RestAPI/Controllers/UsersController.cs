using Microsoft.AspNetCore.Mvc;
using RestAPI.Model;

namespace RestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{

    [HttpGet]
    public List<User> Get()
    {
        return Program.Users;
    }
}
