using Microsoft.EntityFrameworkCore;

namespace UlkeListesiApi.Models
{
  public static class DbInitializer
  {
    public static void Initialize(UlkeDbContext context)
    {
      context.Database.EnsureCreated();

    }
  }
  public class UlkeDbContext : DbContext
  {
    public UlkeDbContext(DbContextOptions<UlkeDbContext> options) : base(options)
    {
    }

    public DbSet<Ulkeler> Ulkeler { get; set; }
  }
}
