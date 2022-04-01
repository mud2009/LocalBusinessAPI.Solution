using Microsoft.EntityFrameworkCore;

namespace LocalBusinessAPI.Models
{
  public class LocalBusinessAPIContext : DbContext
  {
    public LocalBusinessAPIContext(DbContextOptions<LocalBusinessAPIContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Costco", Type = "Retail", Location = "Over there" }
        );
    }

    public DbSet<Business> Businesses { get; set; }
  }
}