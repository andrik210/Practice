using Practice.Domain.Entities;
using Practice.Domain.Repositories;
using System.Threading.Tasks;

namespace Practice.Domain.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateAsync(User user)
        {
            var exist = await _userRepository.IsUniqueAsync(user);

            if (exist)
                return null;

            var result = await _userRepository.CreateAsync(user);
            return result;
        }

        public async Task<User> UpdateAsync(User user)
        {
            var exist = await _userRepository.IsUniqueAsync(user);

            if (exist)
                return null;

            var result = await _userRepository.UpdateAsync(user);
            return result;
        }
    }
}
