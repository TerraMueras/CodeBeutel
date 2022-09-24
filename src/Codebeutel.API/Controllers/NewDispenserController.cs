using Codebeutel.API.Data;
using Codebeutel.API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Codebeutel.API.Controllers;

[ApiController]
[Route("[controller]")]
public class NewDispenserController : ControllerBase
{

    private readonly ILogger<NewDispenserController> _logger;

    private readonly CodebeutelContext _context;

    public NewDispenserController(ILogger<NewDispenserController> logger, CodebeutelContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<NewDispenser>>> GetAll()
    {
        return Ok(await _context.NewDispensers
            .Where(d => !d.IsDeleted)
            .Include(d => d.Approvals)
            .ToArrayAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<NewDispenser>> GetNewDispenser(int id)
    {
        var newDispenser = await _context.NewDispensers
            .Include(d => d.Approvals)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (newDispenser == null)
        {
            return NotFound();
        }

        return Ok(newDispenser);
    }

    [HttpPost]
    public async Task<IActionResult> PostDispenser(NewDispenser newDispenser)
    {
        await _context.NewDispensers.AddAsync(newDispenser);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetNewDispenser), new { id = newDispenser.Id }, newDispenser);
    }

    [HttpPost("{id}/Approve")]
    public async Task<IActionResult> PostApproval(int id)
    {
        var newDispenser = await _context.NewDispensers
            .Include(d => d.Approvals)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (newDispenser == null)
        {
            return NotFound();
        }

        if (newDispenser.Approvals.Count() + 1 == 5)
        {
            var dispenser = new Dispenser()
            {
                Longitude = newDispenser.Longitude,
                Latitude = newDispenser.Latitude,
            };
            await _context.Dispensers.AddAsync(dispenser);

            newDispenser.IsDeleted = true;
            _context.NewDispensers.Update(newDispenser);
            await _context.SaveChangesAsync();

            return Ok(dispenser);
        }
        else
        {
            var approval = new NewDispenserApproval() { NewDispenserId = id };
            await _context.NewDispenserApprovals.AddAsync(approval);
            await _context.SaveChangesAsync();
            return Ok(approval);
        }

    }
}
