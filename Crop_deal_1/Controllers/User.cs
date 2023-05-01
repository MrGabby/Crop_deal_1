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

        [HttpGet("Contact/{contact}")]
        public async Task<IActionResult> GetUserByContact(string contact)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.User_contact == contact);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("Role/{role}")]
        public async Task<IActionResult> GetUserByRole(string role)
        {
            var user = await context.Users.Where(u => u.User_roles.ToLower() == role.ToLower()).ToListAsync();

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

        [HttpGet("Subscribe/{isSubscribe}")]
        public async Task<IActionResult> GetUserBySubscribe(bool isSubscribe)
        {
            var user = await context.Users.Where(u => u.Is_subscribe == isSubscribe).ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("Bank/{bankName}")]
        public async Task<IActionResult> GetUserByBankName(string bankName)
        {
            var user = await context.Users.Where(u => u.Bank_name.ToLower() == bankName.ToLower()).ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("Account/{accountNo}")]
        public async Task<IActionResult> GetUserByBankAccountNo(string accountNo)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Bank_account_no == accountNo);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }


    }
}
