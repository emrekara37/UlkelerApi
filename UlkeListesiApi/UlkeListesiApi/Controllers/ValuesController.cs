using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UlkeListesiApi.Models;

namespace UlkeListesiApi.Controllers
{
  public class TempJson
  {

    public string _Id { get; set; }
    public string _UlkeAdi { get; set; }
    public string _Oncelik { get; set; }
    public string _tr_TR { get; set; }
    public string _en_US { get; set; }
  }
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
