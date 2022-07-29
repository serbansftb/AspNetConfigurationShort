using AspNetConfigurationDemo.Api.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AspNetConfigurationDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeWithInjectedIoptionsSnapshot : ControllerBase
{
    private readonly UserServiceSettings _userServiceSettings;

    public HomeWithInjectedIoptionsSnapshot(IOptionsSnapshot<UserServiceSettings> config)
    {
        _userServiceSettings = config.Value;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { _userServiceSettings.ApiKey, _userServiceSettings.CustomSetting };
    }
}