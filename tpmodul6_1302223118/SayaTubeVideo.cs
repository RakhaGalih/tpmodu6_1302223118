using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = GenerateRandomId();
        //precondition
        Debug.Assert(title.Length <= 100 && title != null, "judul tidak ada atau panjang judul melebihi batas maksimal");
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        //precondition
        Debug.Assert(count <= 10000000, "jumlah penambahan melebihi batas maksimal");
        try
        {
            //exception
            int result = checked(this.playCount + count);
            //postcondition
            this.playCount = result;
        } catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("==== video ====");
        Console.WriteLine($"ID: {id}, \nTitle: {title}, \nPlay Count: {playCount} \n");
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999); // Generate 5-digit random ID
    }
}
