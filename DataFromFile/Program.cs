﻿using System;
using System.IO;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage oma lemmik värv:");
            string usercolor = Console.ReadLine();

            string output = GetLineFromFileData(usercolor);

            if(output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Vabandan, värv ei ole leitud");
            }

        }

        private static string[] ReadDataFromFile()
        {



            string directoryPath = @"C:\Users\opilane\samples";
            string fileName = "Personality.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            return dataFromFile;
        }


            private static string  GetLineFromFileData(string userInput)
            {
                string[] dataFromFile = ReadDataFromFile();
                string result = "";

                foreach(string line in dataFromFile)
                {
                    if (line.Contains(userInput))
                    {
                        result = line;
                         break;
                    }
                }

                return result;



            }


        





    }
}
