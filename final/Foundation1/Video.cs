public class Video : Content
{
    private List<Comment> comments;

    public Video()
    {
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public override int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
    
        foreach (var comment in comments)
        {
            Console.WriteLine($"Comment by {comment._name}: {comment._text}");
        }
    }
}