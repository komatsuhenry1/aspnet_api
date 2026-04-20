using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Models;
using PrimeiraApi.Services;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() // A palavra "async Task" avisa que vai usar await
        {
            // A controller "libera a cadeira do restaurante" enquanto o banco pensa
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            var createdUser = await _userService.CreateUserAsync(user);
            return Created("", createdUser); // O 201 Created é a melhor prática para o POST
        }
    }
}
