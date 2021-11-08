using Microsoft.AspNetCore.Mvc;
using Practice.Domain.Repositories;
using Practice.Domain.Services;
using Practice.Web.ActionModels;
using System.Threading.Tasks;

namespace Practice.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly UserService _userService;

        public UsersController(IUserRepository userRepository, UserService userService)
        {
            _userRepository = userRepository;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetManyAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _userRepository.GetAsync(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserModel model)
        {
            var user = await _userService.CreateAsync(model.ToUser());
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] CreateUserModel model)
        {
            var user = await _userService.UpdateAsync(model.ToUser(id));
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _userRepository.DeleteAsync(id);
            return Ok();
        }
    }
}
