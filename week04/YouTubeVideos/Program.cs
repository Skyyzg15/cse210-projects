using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("How to make a website using HTML and CSS?", "Alice", 300);
        video1.AddComment(new Comment("Diego", "This is a great video!"));
        video1.AddComment(new Comment("Rosa", "Amazing!!"));
        video1.AddComment(new Comment("John", "Not bad"));

        var video2 = new Video("Understanding C#", "Eve", 400);
        video2.AddComment(new Comment("Sarah", "Awesomee!"));
        video2.AddComment(new Comment("Noah", "Incredible video"));
        video2.AddComment(new Comment("Nicole", "Not my favorite"));

        var video3 = new Video("Mastering HTML", "Christian", 500);
        video3.AddComment(new Comment("Jake", "This video is amazing!"));
        video3.AddComment(new Comment("Adriel", "I learned a lot."));
        video3.AddComment(new Comment("Nicolas", "Best video ever!"));

        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}