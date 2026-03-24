using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FraudDetection.Data;
using FraudDetection.Models;
using FraudDetection.Services;

namespace FraudDetection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly FraudEngine _engine;

        public TransactionsController(AppDbContext context, FraudEngine engine)
        {
            _context = context;
            _engine = engine;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Transaction tx)
        {
            var history = await _context.Transactions.ToListAsync();

            var (isFraud, reason) = _engine.Evaluate(tx, history);

            tx.IsFraud = isFraud;
            tx.FraudReason = reason;

            _context.Transactions.Add(tx);
            await _context.SaveChangesAsync();

            return Ok(tx);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Transactions.ToListAsync());
        }

        [HttpGet("fraud")]
        public async Task<IActionResult> GetFraud()
        {
            return Ok(await _context.Transactions.Where(t => t.IsFraud).ToListAsync());
        }
    }
}
