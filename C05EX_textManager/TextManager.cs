using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EX_textManager
{
    public class TextManager
    {
        public List<string> FindLongesWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            List<string> longestWords = new List<string>();

            if (sentence.Length < 1 || words.Length < 1)
                throw new Exception("your sentence is to short");


            string currentLongest = string.Empty;
            //iterate to find longest word
            foreach (string word in words)
            {
                if (word.Length > currentLongest.Length)
                {
                    currentLongest = word;
                }
            }
            int longestCount = 0;
            //iterate to find each word with the same ammount of letters as in last longest word
            foreach (string word in words)
            {
                if (word.Length == currentLongest.Length)
                {
                    longestWords.Add(word);
                }
            }

            //return currentLongest;
            return longestWords;
        }

    }
}

