using Microsoft.AspNetCore.Mvc;

namespace DrSneuss.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}