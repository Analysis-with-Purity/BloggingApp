namespace Blog_App.Models;

public class Comments
{
    public int Id { get; set; }
    public string CommentContent { get; set; }
    public int CreatorId { get; set; }
    public int PostId { get; set; }
    
    //Navigation
    public User User { get; set; }
    public BlogPosts BlogPosts { get; set; }
}