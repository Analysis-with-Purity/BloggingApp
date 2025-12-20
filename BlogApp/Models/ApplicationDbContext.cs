using Microsoft.EntityFrameworkCore;

namespace Blog_App.Models;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    } 
    
    public DbSet<Creator> Creators { get; set; }
    public DbSet<Gender> Gender { get; set; }
    public DbSet<Post> Posts { get; set; }
}