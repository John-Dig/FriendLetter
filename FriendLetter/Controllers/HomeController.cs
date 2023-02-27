using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello Muffin!"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye you silly Muffin!!!"; }
    [Route("/")]
    public ActionResult Letter() { return View(); }
  }


}