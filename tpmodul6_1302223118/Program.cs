using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [RAKHA_GALIH_NUGRAHA_SUKMA]");
        video.PrintVideoDetails();

        // Menambahkan 100 pemutaran ke video
        for (int i = 1; i <= 216; i++)
        {
            video.IncreasePlayCount(10000000);
        }
        video.PrintVideoDetails();
    }
}