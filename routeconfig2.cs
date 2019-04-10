public static void RegisterRoutes(RouteCollection routes)
{
  routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

  routes.MapRoute(
    name: "AltPage",
    url: "Alternative/{action}/{id}",
    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
  );

  routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
  );
}
