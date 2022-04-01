using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessAPI.Models;

namespace LocalBusinessAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly LocalBusinessAPIContext _db;

    public BusinessesController(LocalBusinessAPIContext db)
    {
      _db = db;
    }
    // GET: api/Businesses
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get()
    {
      var query = _db.Businesses.AsQueryable();

      return await query.ToListAsync();
    }
    // GET: api/Businesses/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
        var business = await _db.Businesses.FindAsync(id);

        if (business == null)
        {
            return NotFound();
        }

        return business;
    }

  }
}