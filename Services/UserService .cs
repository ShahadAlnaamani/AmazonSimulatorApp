using AmazonSimulatorApp.Data.Repositories;
using AmazonSimulatorApp.Data;

namespace AmazonSimulatorApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> RegisterUserAsync(User user)
        {
            if (await _userRepository.EmailExistsAsync(user.Email))
            {
                return "The email is already in use.";
            }

            await _userRepository.AddUserAsync(user);

            return "Registration successful!";
        }

        public async Task<User> LoginUserAsync(string email, string password)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);

            if (user == null || user.Password != password)
            {
                return null;
            }

            helper.CurrentUserID = user.ID;

            helper.CurrentUserRole = user.Role;

            return user;
        }
    }
}
