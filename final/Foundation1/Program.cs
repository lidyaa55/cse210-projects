
class Program
{
    static void Main()
    {
         // Creating videos
        Video video1 = new Video("Summer Dance", "Almaz", 120);
        Video video2 = new Video("Nature Beauty", "John", 150);
        Video video3 = new Video("Cooking Tutorial", "ChefMia", 180);

        // Adding 3-4 comments to each video
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Bob", "I enjoyed this content.");
        video1.AddComment("Carol", "Nice choreography.");
        video1.AddComment("Dave", "The music is fantastic!");

        video2.AddComment("Charlie", "Amazing scenery!");
        video2.AddComment("David", "Nice video quality.");
        video2.AddComment("Eva", "I wish I could visit this place.");

        video3.AddComment("Frank", "Well explained steps.");
        video3.AddComment("Grace", "The final dish looks delicious.");
        video3.AddComment("Hank", "Thanks for sharing these recipes.");
        video3.AddComment("Ivy", "I'll definitely try this at home.");

       // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying information about each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Video: {video.Title} by {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("\nComments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine("\n");
        }
    }
}
