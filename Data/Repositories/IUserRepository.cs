
namespace AmazonSimulatorApp.Data.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task<bool> EmailExistsAsync(string email);
        Task<User> GetUserByEmailAsync(string email);
    }
}