using System;

class Program
{
    static void Main(string[] args)
    {
        var video = new SayaTubeVideo("Tutorial Design By Contract - [RAKHA_GALIH_NUGRAHA_SUKMA]");
        video.PrintVideoDetails();

        // Menguji metode IncreasePlayCount dengan nilai besar
        video.IncreasePlayCount(1000000000);

        // Menambahkan 10.000.000 pemutaran ke video sebanyak 216 kali
        for (int i = 1; i <= 216; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();
    }
}