using Codebeutel.API.Data;
using Codebeutel.API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Codebeutel.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DispenserController : ControllerBase
{

    private readonly ILogger<DispenserController> _logger;

    private readonly CodebeutelContext _context;

    public DispenserController(ILogger<DispenserController> logger, CodebeutelContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dispenser>>> GetAll()
    {
        return Ok(await _context.Dispensers
            .Where(d => !d.IsDeleted)
            .Include(d => d.Reports)
            .ToArrayAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dispenser>> GetDispenser(int id)
    {
        var dispenser = await _context.Dispensers
            .Include(d => d.Reports)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (dispenser == null)
        {
            return NotFound();
        }

        return Ok(dispenser);
    }

    [HttpPost]
    public async Task<IActionResult> PostDispenser(Dispenser dispenser)
    {
        await _context.Dispensers.AddAsync(dispenser);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetDispenser), new { id = dispenser.Id }, dispenser);
    }

    [HttpPost("{id}/Report")]
    public async Task<IActionResult> PostReport(int id)
    {
        var dispenser = await _context.Dispensers
            .Include(d => d.Reports)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (dispenser == null)
        {
            return NotFound();
        }

        if (dispenser.Reports.Count() == 5)
        {
            dispenser.IsDefect = true;
            _context.Update(dispenser);
        }

        var report = new Report() { DispenserId = id };

        await _context.Reports.AddAsync(report);
        await _context.SaveChangesAsync();

        return Ok("Report created");
    }
}
