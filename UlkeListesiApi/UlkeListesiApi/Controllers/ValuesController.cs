using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UlkeListesiApi.Models;

namespace UlkeListesiApi.Controllers
{
  
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    private readonly UlkeDbContext _context;

    public ValuesController(UlkeDbContext context)
    {
      _context = context;
    }

    // GET api/values
    [HttpGet]
    public List<Ulkeler> Get()
    {
      return _context.Ulkeler.ToList();
    }

  }
}
