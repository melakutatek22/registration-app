using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    public AuthController(AppDbContext context) => _context = context;

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return Ok("User registered successfully.");
    }
}