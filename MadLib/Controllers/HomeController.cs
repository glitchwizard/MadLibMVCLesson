using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public  class HomeController : Controller
  {
    // Change these
    [Route("/")]
    public ActionResult Form() { return View (); }

    [Route("/MadLib")]
    public ActionResult MadLib(string noun, string name, string anEvent) {
      MadLibsObject myMadlib = new MadLibsObject();
      myMadlib.SetNoun(noun);
      myMadlib.SetName(name);
      myMadlib.SetEvent(anEvent);
      return View(myMadlib);
    }

  }
}
