using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1wordcounter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var folder = @".\Test";
            var TxtFileCalculator = new TxtFileCalculator();
            var txtFiles = TxtFileCalculator.GetFiles(folder);
            int allWords = 0;
            foreach (var txtFile in txtFiles)
            {
                var words = TxtFileCalculator.GetWords(txtFile);
                System.Console.WriteLine($"Number of words in {txtFile}: " + words);
                allWords = allWords + words;
            }
            System.Console.WriteLine($"Number of words in all files: " + allWords);

        }
    }
}
