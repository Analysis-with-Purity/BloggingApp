namespace Blog_App.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PhoneNo { get; set; }
    public DateTime DOB { get; set; }
    public int GenderId { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string HashedPassword { get; set; }
    
    public ICollection<BlogPosts> Posts { get; set; }
    public ICollection<Comments> Comment { get; set; }
    
    //Navigation 
    public Gender Gender { get; set; }
    
}