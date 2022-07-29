namespace AspNetConfigurationDemo.Api.Services.UserService
{
    public interface IUserService
    {
        public Task<List<string>> GetUserSettings();
    }
}
