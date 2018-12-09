using Microsoft.EntityFrameworkCore;

namespace VueProject 
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<FoodRecord> FoodRecords { get; set; }
  }
}