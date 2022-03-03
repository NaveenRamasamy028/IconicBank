using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace IconicBank1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly iconicbankingContext db;
        public TransactionController(iconicbankingContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTransactions()
        {
            return Ok(await db.Transactions.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddTransaction(Transaction e)
        {
            db.Transactions.Add(e);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTransaction(int id, Transaction e1)
        {
            Transaction e = db.Transactions.Find(id);
            db.Entry(e).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTransaction(int id)
        {
            Transaction e = db.Transactions.Find(id);
            db.Transactions.Remove(e);
            await db.SaveChangesAsync();
            return Ok();
        }
        
            
}






    }

