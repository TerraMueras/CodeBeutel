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

    [HttpGet(Name = "GetDispensers")]
    public async Task<IEnumerable<Dispenser>> Get()
    {
        return await _context.Dispensers.ToArrayAsync();
    }
}
