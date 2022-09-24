using Codebeutel.API.Data;
using Codebeutel.API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Codebeutel.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DogFriendlyPlacesController : ControllerBase
{

    private readonly ILogger<DogFriendlyPlacesController> _logger;

    private readonly CodebeutelContext _context;

    public DogFriendlyPlacesController(ILogger<DogFriendlyPlacesController> logger, CodebeutelContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DogFriendlyPlace>>> GetAll()
    {
        return Ok(await _context.DogFriendlyPlaces
            .Include(d => d.Category)
            .ToArrayAsync());
    }
}
