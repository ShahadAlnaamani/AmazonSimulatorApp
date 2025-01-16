using AmazonSimulatorApp.Data;

namespace AmazonSimulatorApp.Services
{
    public interface IUserService
    {
        Task<User> LoginUserAsync(string email, string password);
        Task<string> RegisterUserAsync(User user);
    }
}