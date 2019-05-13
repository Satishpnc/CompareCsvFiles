using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CompareCsvFiles
{
    public class CompareCsv
    {
        public static Boolean isFileExist(string filePath)
        {
            return File.Exists(filePath);
        }

        public static void getDifferencesOfCsvFiles(string fileOnePath, string fileTwoPath)
        {
            // Prepare IEnumerable data sources .
            var fileOne = File.ReadLines(fileOnePath);
            var fileTwo = File.ReadLines(fileTwoPath);

            int counter = 1;
            Boolean anyDifferences = false;

            // Find the differences
            IEnumerable<String> differenceQuery = fileOne.Except(fileTwo);

            // Print the diffrences.
            Console.WriteLine("\n Validating Differences in FileOne and FileTwo \n");

            foreach (string s in differenceQuery)
            {
                Console.WriteLine("\n********* Difference {0} *********\n", counter);
                Console.WriteLine("\n" + s + "\n");
                anyDifferences = true;
                counter++;
            }

            if (!anyDifferences)
            {
                Console.WriteLine("\nBoth fileOne and fileTwo are same!\n");
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a fileOnePath - ");
            var filePathOne = @"" + Console.ReadLine();

            Console.Write("Enter a fileTwoPath - ");
            var filePathTwo = @"" + Console.ReadLine();

            if (isFileExist(filePathOne) && isFileExist(filePathTwo))
            {
                getDifferencesOfCsvFiles(filePathOne, filePathTwo);
            }
            else
            {
                Console.WriteLine("Given File Path is incorrect");
            }

        // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
        Console.ReadKey();

        }
    }
}

