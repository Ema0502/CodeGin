using Microsoft.EntityFrameworkCore;
using CodeGin.Models;

namespace CodeGin.Data
{
    public class CodeGinContext : DbContext
    {
        public CodeGinContext(DbContextOptions<CodeGinContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}