using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessAPI.Models;

namespace LocalBusinessAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocalBusinessAPIController : ControllerBase
  {
    private readonly LocalBusinessAPIContext _db;

    public LocalBusinessAPIController(LocalBusinessAPIContext db)
    {
      _db = db;
    }
    // GET: api/LocalBusiness
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get()
    {
      var query = _db.Businesses.AsQueryable();

      return await query.ToListAsync();
    }

  }
}