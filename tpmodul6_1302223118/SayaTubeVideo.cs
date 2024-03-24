using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
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
