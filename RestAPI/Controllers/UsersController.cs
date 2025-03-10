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

    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        var user = Program.Users.FirstOrDefault(x => x.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        return user;
    }

    [HttpPost]
    public ActionResult<int> Post([FromBody] User user ) {
        user.Id = Program.Users.Max(x => x.Id) + 1;
        Program.Users.Add(user);
        return user.Id;
    }


    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] User updatedUser)
    {
        var user = Program.Users.FirstOrDefault(x => x.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        user.Name = updatedUser.Name;
        user.Email = updatedUser.Email;
        return NoContent();
    }


    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var user = Program.Users.FirstOrDefault(x => x.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        Program.Users.Remove(user);
        return NoContent();
    }
}
