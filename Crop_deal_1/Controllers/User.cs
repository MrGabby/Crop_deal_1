using Crop_deal_1.Data;
using Crop_deal_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Drawing.Drawing2D;


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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if (context.Users == null)
            {
                return NotFound();
            }
            return await context.Users.ToListAsync();
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

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new User
            {
                User_name = userDto.User_name,
                Email_id = userDto.Email_id,
                Is_Active = userDto.Is_Active
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserById), new { id = user.User_id }, user);
        }
    }
}
