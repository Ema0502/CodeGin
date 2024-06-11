namespace CodeGin.Models
{
  public class Friend
  {
    public Guid Id { get; set; }
    public Guid User1Id { get; set; }
    public Guid User2Id { get; set; }
    public string? State { get; set; }
  }
}
