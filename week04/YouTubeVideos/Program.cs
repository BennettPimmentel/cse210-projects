using System;
using System.Collections.Generic;
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nComments: {GetCommentCount()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Intro to C#", "CodeAcademy", 300);
        video1.AddComment("Alice", "Great explanation!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "Nice tutorial.");

        Video video2 = new Video("OOP Concepts", "Tech Guru", 450);
        video2.AddComment("Dave", "This clarified a lot of things!");
        video2.AddComment("Eve", "Perfect example!");

        Video video3 = new Video("Data Structures", "Coding Pro", 600);
        video3.AddComment("Frank", "Loved this session!");
        video3.AddComment("Grace", "Could you make one on algorithms?");
        video3.AddComment("Hank", "Very detailed and useful.");
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
 