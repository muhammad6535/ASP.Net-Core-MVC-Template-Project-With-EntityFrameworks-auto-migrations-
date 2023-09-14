using Microsoft.AspNetCore.Mvc;
using myApp.Models;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly MyDbContext _context;

    public UserController(MyDbContext context)
    {
        _context = context;
    }

    //[HttpGet("{id}")]
    //public async Task<IActionResult> GetUserById(int id)
    //{
    //    _context.Users.Where(o => o.Id == id);
    //    var user = await _myService.GetUserByIdAsync(id);

    //    if (user == null)
    //    {
    //        return NotFound();
    //    }

    //    return Ok(user);
    //}

    //[HttpGet]
    //public async Task<IActionResult> GetAllUsers()
    //{
    //    var users = await _myService.GetAllUsersAsync();
    //    return Ok(users);
    //}

    //[HttpPost]
    //public async Task<IActionResult> CreateUser(User user)
    //{
    //    if (user == null)
    //    {
    //        return BadRequest();
    //    }

    //    await _myService.CreateUserAsync(user);
    //    return CreatedAtAction("GetUserById", new { id = user.Id }, user);
    //}
}