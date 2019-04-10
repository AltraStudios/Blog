[HttpPost]
public ActionResult ContactUs(ContactMessage contactMessage)
{
  if(ModelState.IsValid)
  {
    ViewBag.Name = contactMessage.Name;
    return View("Thanks", contactMessage);
  }
  else
  {
    return View();
  }
}
