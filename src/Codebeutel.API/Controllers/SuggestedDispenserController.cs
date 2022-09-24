using Codebeutel.API.Data;
using Codebeutel.API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Codebeutel.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SuggestedDispenserController : ControllerBase
{

    private readonly ILogger<SuggestedDispenserController> _logger;

    private readonly CodebeutelContext _context;

    public SuggestedDispenserController(ILogger<SuggestedDispenserController> logger, CodebeutelContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SuggestedDispenser>>> GetAll()
    {
        return Ok(await _context.SuggestedDispensers
            .Where(d => !d.IsDeleted)
            .Include(d => d.Approvals)
            .ToArrayAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SuggestedDispenser>> GetSuggestedDispenser(int id)
    {
        var suggestedDispenser = await _context.SuggestedDispensers
            .Include(d => d.Approvals)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (suggestedDispenser == null)
        {
            return NotFound();
        }

        return Ok(suggestedDispenser);
    }

    [HttpPost]
    public async Task<IActionResult> PostDispenser(SuggestedDispenser suggestedDispenser)
    {
        await _context.SuggestedDispensers.AddAsync(suggestedDispenser);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetSuggestedDispenser), new { id = suggestedDispenser.Id }, suggestedDispenser);
    }

    [HttpPost("{id}/Approve")]
    public async Task<IActionResult> PostApproval(int id)
    {
        var suggestedDispenser = await _context.SuggestedDispensers
            .Include(d => d.Approvals)
            .FirstOrDefaultAsync(d => d.Id == id);

        if (suggestedDispenser == null)
        {
            return NotFound();
        }

        if (suggestedDispenser.Approvals.Count() >= 4 && !suggestedDispenser.NotificationSent)
        {
            // TODO: Trigger a notification in the Stadtwerke

            suggestedDispenser.NotificationSent = true;
            _context.SuggestedDispensers.Update(suggestedDispenser);
            await _context.SaveChangesAsync();
            return Ok(suggestedDispenser);
        }
        else
        {
            var approval = new SuggestedDispenserApproval() { SuggestedDispenserId = id };
            await _context.SuggestedDispenserApprovals.AddAsync(approval);
            await _context.SaveChangesAsync();
            return Ok(approval);
        }
    }
}
