using BudgetTrackerApi.Data;
using BudgetTrackerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BudgetTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetTrackerController : ControllerBase
    {

        private readonly BudgetTrackerDbContext _context;

        public BudgetTrackerController(BudgetTrackerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Record>>> GetRecords()
        {
            return Ok(await _context.Records.ToListAsync());
        }
    }
}
