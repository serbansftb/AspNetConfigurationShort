using AspNetConfigurationDemo.Api.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace AspNetConfigurationDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeWithInjectedConfigurationController : ControllerBase
{
    private readonly string _setting1;

    private readonly UserServiceSettings _userServiceSettings;

    public HomeWithInjectedConfigurationController(IConfiguration config)
    {
        _setting1 = config.GetValue<string>("Setting1");

        _userServiceSettings = new UserServiceSettings()
        {
            CustomSetting = config.GetValue<string>("UserServiceSettings__CustomSetting"),
            ApiKey = config.GetValue<string>("UserServiceSettings:ApiKey")
        };

    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { _userServiceSettings.ApiKey, _userServiceSettings.CustomSetting };
    }
}