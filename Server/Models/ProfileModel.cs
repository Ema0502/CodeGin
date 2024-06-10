namespace CodeGin.Models;

public class Profile 
{
  public Guid Id { get; set; }
  public Guid UserId { get; set; }
  public string? Biography { get; set; }
  public string? ProfileImage { get; set; }
  public string? FrontImage { get; set; }
  public string? Location { get; set; }
}
