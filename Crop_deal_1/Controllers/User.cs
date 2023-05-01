using Crop_deal_1.Data;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            int Delaman = 0;
            return View();
        }
    }
}
