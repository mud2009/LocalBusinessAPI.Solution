using System;
using System.Collections.Generic;
using System.Linq;
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
    // PUT: api/Businesses/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutBusiness(int id, Business business)
    {
        if (id != business.BusinessId)
        {
            return BadRequest();
        }

        _db.Entry(business).State = EntityState.Modified;

        try
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BusinessExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }
    // POST: api/Businesses
    [HttpPost]
    public async Task<ActionResult<Business>> PostBusiness(Business business)
    {
        _db.Businesses.Add(business);
        await _db.SaveChangesAsync();

        return CreatedAtAction("GetBusiness", new { id = business.BusinessId }, business);
    }
    // DELETE: api/Businesses/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
        var business = await _db.Businesses.FindAsync(id);
        if (business == null)
        {
            return NotFound();
        }

        _db.Businesses.Remove(business);
        await _db.SaveChangesAsync();

        return NoContent();
    }
    private bool BusinessExists(int id)
    {
        return _db.Businesses.Any(e => e.BusinessId == id);
    }

  }
}