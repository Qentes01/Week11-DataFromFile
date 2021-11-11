using System;
using System.IO;


namespace Chuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectroty = $@"C:\Users\opilane\samples";
            string fileName = "Chuck.txt";
            string FullFilePath = $@"{rootdirectroty}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(FullFilePath);
            Random rnd1 = new Random();
            Console.WriteLine(dataFromFile[rnd1.Next(dataFromFile.Length)]);
        }
    }
}

