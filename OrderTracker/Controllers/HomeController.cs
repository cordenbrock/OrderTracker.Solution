using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
  public class OrderTracker : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}