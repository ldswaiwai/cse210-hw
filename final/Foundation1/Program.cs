using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video {_title = "Video 1", _author = "Author A", _length = 300};
        Video v2 = new Video {_title = "Video 2", _author = "Author B", _length = 400};
        Video v3 = new Video {_title = "Video 3", _author = "Author C", _length = 500};

        v1.AddComment(new Comment {_name = "Commenter 1", _text = "It is great!"});
        v1.AddComment(new Comment {_name = "Commenter 2", _text = "Nice job!"});
        v1.AddComment(new Comment {_name = "Commenter 3", _text = "Thank you for doing that!"});

        v2.AddComment(new Comment {_name = "Commenter 4", _text = "Fantastic!"});
        v2.AddComment(new Comment {_name = "Commenter 5", _text = "You are awesome!"});
        v2.AddComment(new Comment {_name = "Commenter 6", _text = "Great job!"});

        v3.AddComment(new Comment {_name = "Commenter 7", _text = "Is it real?!"});
        v3.AddComment(new Comment {_name = "Commenter 8", _text = "Awesome!"});
        v3.AddComment(new Comment {_name = "Commenter 9", _text = "It is great!"});

        List<Video> videos = new List<Video> {v1, v2, v3};

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }

    }

}