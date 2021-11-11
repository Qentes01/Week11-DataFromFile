using System;
using System.IO;

namespace ChuckRnd3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(RandomLineFromFile);
            }

        }

        private static string RandomLineFromFile()
        {

            string filePath = @"C:\Users\opilane\samples";

            string[] dataFromFile = File.ReadAllLines(filePath);

            Random rnd = new Random();
            int ranodomIndex = rnd.Next(0, dataFromFile.Length);
            return dataFromFile[ranodomIndex];
        }
    }
}
