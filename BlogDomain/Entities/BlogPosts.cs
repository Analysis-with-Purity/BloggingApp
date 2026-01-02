namespace Blog_App.Models;

public class BlogPosts
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string PostContent { get; set; }
    public string PostImageUrl { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public int CreatorId { get; set; }
    
    public ICollection<Comments> Comments { get; set; }
    
    //Navigation properties
    public User User { get; set; }

}