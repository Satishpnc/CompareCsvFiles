using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CompareCsvFiles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a fileOnePath - ");
            var fileOnePath = @"" + Console.ReadLine();

            Console.Write("Enter a fileTwoPath - ");
            var fileTwoPath = @"" + Console.ReadLine();

            //  /Users/peddasna/Downloads/Sample2.csv
            // Prepare IEnumerable data sources .
            var fileOne = File.ReadLines(fileOnePath);
            var fileTwo = File.ReadLines(fileTwoPath);
            int counter = 0;
            Boolean anyDifferences = false;

            // Find the differences
            IEnumerable<String> differenceQuery = fileOne.Except(fileTwo);

             // Print the diffrences.
                Console.WriteLine("\n Validating Differences in FileOne and FileTwo \n");

                foreach (string s in differenceQuery) { 
                    Console.WriteLine("\n********* Difference in Line {0} *********\n", counter + 1);
                    Console.WriteLine("\n" + s + "\n");
                    anyDifferences = true;
                }

            if(!anyDifferences)
            {
                Console.WriteLine("\nBoth fileOne and fileTwo are same!\n");
            }

            // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();

        }
    }
}

