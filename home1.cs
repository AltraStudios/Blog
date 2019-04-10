using ASP.NET_MVC_Tutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Tutorials.Controllers
{
  public class HomeController : Controller
  {

    public ActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public ActionResult ContactUs()
    {
      return View();
    }

    [HttpPost]
    public ActionResult ContactUs(ContactMessage contactMessage)
    {
      ViewBag.Name = contactMessage.Name;
      return View("Thanks");
    }
  }
}
