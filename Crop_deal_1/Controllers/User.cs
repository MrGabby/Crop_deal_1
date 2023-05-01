using Crop_deal_1.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Crop_deal_1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class User : Controller
    {
        private readonly ApiDbContext context;

        public User(ApiDbContext context)
        {
            this.context = context;  
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("Name/{name}")]
        public async Task<IActionResult> GetUserByName(string name)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.User_name == name);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("Email/{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Email_id == email);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("IsActive/{isActive}")]
        public async Task<IActionResult> GetUserByIsActive(bool isActive)
        {
            var user = await context.Users.Where(u => u.Is_Active == isActive).ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
