
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Learning C#", "John Smith", 300);
        Video video2 = new Video("Python for Beginners", "Mary Johnson", 450);
        Video video3 = new Video("How to Make a Website", "David Brown", 600);


        video1.AddComment(new Comment("Angel", "Very helpful video!"));
        video1.AddComment(new Comment("Flor", "I learned a lot."));
        video1.AddComment(new Comment("Steven", "Great explanation!"));

        video2.AddComment(new Comment("Angel", "Amazing tutorial."));
        video2.AddComment(new Comment("Jared", "Python is interesting!"));
        video2.AddComment(new Comment("Romy", "Thanks for sharing."));

        video3.AddComment(new Comment("Elaine", "Beautiful website."));
        video3.AddComment(new Comment("Anthony", "This helped me a lot."));
        video3.AddComment(new Comment("Ronald", "Great job!"));


        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };


        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine(video.GetVideoInfo());

            Console.WriteLine("\nComments:");
            video.DisplayComments();

            Console.WriteLine();
        }
    }
}
