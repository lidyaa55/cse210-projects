
public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        Comments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
