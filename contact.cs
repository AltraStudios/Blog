[HttpPost]
public ActionResult ContactUs(ContactMessage contactMessage)
{
  ViewBag.Name = contactMessage.Name;
  return View("Thanks",contactMessage);
}
