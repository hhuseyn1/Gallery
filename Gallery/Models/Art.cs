namespace Gallery.Models;

public class Art
{
    public string? ImageUrl { get; set; }
    public bool IsChanged{ get; set; }=false;
    public string? Title { get; set; }

}