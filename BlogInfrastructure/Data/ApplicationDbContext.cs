using Microsoft.EntityFrameworkCore;

namespace Blog_App.Models;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    } 
    
    public DbSet<User> Creators { get; set; }
    public DbSet<Gender> Gender { get; set; }
    public DbSet<BlogPosts> Posts { get; set; }
    public DbSet<Comments> Comments { get; set; }
}