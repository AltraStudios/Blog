namespace ASP.NET_MVC_Tutorials.Models
{
  public class ContactMessage
  {
    [Required(ErrorMessage = "Please enter your name")]
    public string Name {get; set;}

    [Required( ErrorMessage ="Please enter your email")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please type a message")]
    public string Message { get; set; }

    public bool IsSatisfied { get; set; }
  }
}
