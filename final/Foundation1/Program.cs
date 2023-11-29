
class Program
{
    static void Main()
    {
        // Creating instances of Video and Comment
        Video myVideo = new Video("Title of My Video", "John Doe", 120);
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "I enjoyed this content.");

        // Setting properties
        myVideo.AddComment(comment1.CommenterName, comment1.CommentText);
        myVideo.AddComment(comment2.CommenterName, comment2.CommentText);

        // Calling methods to demonstrate functionality
        Console.WriteLine($"Video: {myVideo.Title} by {myVideo.Author}");
        Console.WriteLine($"Length: {myVideo.LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {myVideo.GetNumberOfComments()}");

        Console.WriteLine("\nComments:");
        foreach (var comment in myVideo.Comments)
        {
            Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
        }
    }
}
