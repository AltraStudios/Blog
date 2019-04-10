[Authorize]
// Require authenticated requests.
public class HomeController : ApiController
{
  public Get() { . . . }
  public IHttpActionResult Post() { . . . }
}
