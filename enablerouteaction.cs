using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Tutorials.Controllers
{
  [Route("")]
  [Route("Attribute")]
  public class HomeController : Controller
  {

    public string Index()
    {
      return "Hello world";
    }
  }
}
