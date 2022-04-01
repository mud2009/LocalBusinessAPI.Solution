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
          new Business { BusinessId = 1, Name = "Costco", Type = "Retail", Location = "Over there" },
          new Business { BusinessId = 2, Name = "Mcdonalds", Type = "Fast food", Location = "Over there" },
          new Business { BusinessId = 3, Name = "Walmart", Type = "Retail", Location = "Over there" },
          new Business { BusinessId = 4, Name = "Walgreens", Type = "Pharmacy", Location = "Over there" },
          new Business { BusinessId = 5, Name = "Hardees", Type = "Fast food", Location = "Over there" },
          new Business { BusinessId = 6, Name = "Armani", Type = "Luxury", Location = "Over there" },
          new Business { BusinessId = 7, Name = "ToysRus", Type = "Toys", Location = "Over there" },
          new Business { BusinessId = 8, Name = "Best Buy", Type = "Electronics", Location = "Over there" },
          new Business { BusinessId = 9, Name = "Lil Caesars", Type = "Pizza", Location = "Over there" },
          new Business { BusinessId = 10, Name = "Frank's", Type = "Sandwiches", Location = "Over there" }
        );
    }

    public DbSet<Business> Businesses { get; set; }
  }
}