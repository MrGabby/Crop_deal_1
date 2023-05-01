using Crop_deal_1.Data;
using Crop_deal_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Crop_deal_1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly ApiDbContext context;

        public UserController(ApiDbContext context)
        {
            this.context = context;
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

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(string name, string email, bool is_active)
        {
            var user = new User
            {
                User_name = name,
                Email_id = email,
                Is_Active = is_active
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserById), new { id = user.User_id }, user);
        }
    }
}
