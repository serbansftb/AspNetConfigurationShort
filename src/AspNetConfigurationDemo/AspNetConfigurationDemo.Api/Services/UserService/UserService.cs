using Microsoft.Extensions.Options;

namespace AspNetConfigurationDemo.Api.Services.UserService;

public class UserService : IUserService
{
    private readonly UserServiceSettings _settings;

    public UserService(IOptionsSnapshot<UserServiceSettings> config)
    {
        _settings = config.Value;
    }

    public Task<List<string>> GetUserSettings()
    {
        return Task.FromResult(new List<string>()
        {
            _settings.ApiKey, _settings.CustomSetting
        });
    }
}
