using AspNetConfigurationDemo.Api.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace AspNetConfigurationDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _userService.GetUserSettings());
    }
}