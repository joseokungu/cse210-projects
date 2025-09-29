using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new("Top 5 Sci-Fi Movies", "Jose Okitandende", 200);
        video1.AddComment(new Comment("Alice", "Amazing picks!"));
        video1.AddComment(new Comment("Bob", "I expected Star Wars on this list."));
        video1.AddComment(new Comment("Charlie", "Great selection."));

        Video video2 = new("Easy Pasta Recipes", "Chef Emma", 300);
        video2.AddComment(new Comment("Dana", "Tried the recipe, it was delicious!"));
        video2.AddComment(new Comment("Eve", "Quick and easy dinner idea."));
        video2.AddComment(new Comment("Frank", "Can you make a gluten-free version?"));
        video2.AddComment(new Comment("Grace", "Loved it!"));

        Video video3 = new("C# for Beginners",  "CodeMaster", 900);
        video3.AddComment(new Comment("Heidi", "Very helpful for beginners."));
        video3.AddComment(new Comment("Ivan", "Could you explain loops more?"));
        video3.AddComment(new Comment("Judy", "Subscribed! Waiting for the next tutorial."));

        Video[] videos = { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine("Video details:");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.CommentsCount()}");

            Console.WriteLine("");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._username}");
                Console.WriteLine(comment._text);
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("");
        }
    }

}