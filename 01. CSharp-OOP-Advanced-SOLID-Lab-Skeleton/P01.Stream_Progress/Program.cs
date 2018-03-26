using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {   
            var file = new File("Tonko", 30, 165);
            var music = new Music("Lili Ivanova", "Vetrove", 100, 586);
            var streamProgresInfo = new StreamProgressInfo(file);
            var streamProgresInfo1 = new StreamProgressInfo(music);
            Console.WriteLine(streamProgresInfo.CalculateCurrentPercent());
            Console.WriteLine(streamProgresInfo1.CalculateCurrentPercent());
        }
    }
}
