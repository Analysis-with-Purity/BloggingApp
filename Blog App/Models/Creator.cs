namespace Blog_App.Models;

public class Creator
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DOB { get; set; }
    public Guid GenderId { get; set; }
    public long Phone { get; set; }
    
    //Navigation 
    public Gender Gender { get; set; }
}