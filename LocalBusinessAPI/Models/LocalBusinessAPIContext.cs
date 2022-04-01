using Microsoft.EntityFrameworkCore;

namespace LocalBusinessAPI.Models
{
  public class LocalBusinessAPIContext : DbContext
  {
    public LocalBusinessAPIContext(DbContextOptions<LocalBusinessAPIContext> options) : base(options)
    {

    }
    public DbSet<Business> Businesses { get; set; }
  }
}