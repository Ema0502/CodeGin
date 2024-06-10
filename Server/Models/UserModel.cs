namespace CodeGin.Models;
public class User
{
  public Guid Id { get; set; }
  public string? Username { get; set; }
  public string? Gender { get; set; }
  public DateTime Birthdate { get; set; }
  public string? Email { get; set; }
  public string? Password { get; set; }
  public string? ProfileImage { get; set; } 
  public bool BanUser { get; set; }
}
