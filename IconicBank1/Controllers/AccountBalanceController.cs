using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IconicBank1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountBalanceController : ControllerBase
    {
        private readonly iconicbankingContext db;
        public AccountBalanceController(iconicbankingContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetBalances()
        {
            return Ok();
        }
    }
}
