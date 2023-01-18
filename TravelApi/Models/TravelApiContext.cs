using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>()
        .HasData(
          new User { UserId = 1, UserName = "david", Password = "epicodus" }
        );
    }
  }
}