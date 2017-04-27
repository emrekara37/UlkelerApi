using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UlkeListesiApi.Models;

namespace UlkeListesiApi.Controllers
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
