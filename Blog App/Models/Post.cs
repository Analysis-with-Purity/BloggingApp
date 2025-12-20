namespace Blog_App.Models;

public class Post
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public string PostImageUrl { get; set; }
    public Guid CreatorId { get; set; }
    
    //Navigation properties
    public Creator Creator { get; set; }

}