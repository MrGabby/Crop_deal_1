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
        public IActionResult Index()
        {
            return View();
        }
    }
}
