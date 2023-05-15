using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1wordcounter
{
    internal class TxtFileCalculator
    {

        public string[] GetFiles (string folder)
        {
            var txtFiles = Directory.GetFiles(folder, "*.txt");
            return txtFiles;
        }

        public int GetWords (string txtFile) 
        {
            var readFile = File.ReadAllText(txtFile);
            var str = readFile.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = str.Length;
            return counter;
        }

    }
}
