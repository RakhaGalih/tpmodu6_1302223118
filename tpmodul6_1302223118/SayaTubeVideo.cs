using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private readonly int _id;
    private readonly string _title;
    private int _playCount;

    public SayaTubeVideo(string title)
    {
        // Validasi prasyarat untuk judul
        if (title == null || title.Length > 100)
        {
            throw new ArgumentException("Judul harus tidak null dan maksimal 100 karakter.");
        }

        _id = GenerateRandomId();
        _title = title;
        _playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // Validasi prasyarat untuk count
        if (count > 10000000)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Jumlah harus 10.000.000 atau kurang.");
        }

        try
        {
            // Menggunakan checked untuk menangani overflow
            _playCount = checked(_playCount + count);
        }
        catch (OverflowException)
        {
            // Menangani kesalahan overflow
            Console.WriteLine("Error: Play count overflowed.");
        }
    }

    public void PrintVideoDetails()
    {
        // Mencetak detail video
        Console.WriteLine("==== Detail Video ====");
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Judul: {_title}");
        Console.WriteLine($"Jumlah Pemutaran: {_playCount}\n");
    }

    private static int GenerateRandomId()
    {
        // Menghasilkan ID acak 5 digit
        var random = new Random();
        return random.Next(10000, 99999);
    }
}