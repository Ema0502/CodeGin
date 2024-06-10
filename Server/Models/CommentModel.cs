using CodeGin.Models;

{
    public class Comment
    {
      public Guid Id { get; set; }
      public Guid UserId { get; set; }
      public string Content { get; set; }
      public DateTime CreatedComment { get; set; }
    }
}