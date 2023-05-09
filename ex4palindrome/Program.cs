using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ex4palindrome

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your word/phrase to check whether it is a palindrome: ");
            string word = Console.ReadLine();

            word = word.ToLower();
            word = word.Replace(" ", "");
            string patern = @"[^a-z0-9]";
            var cleanInput = Regex.Replace(word, patern, "");
            //cleanInput = cleanInput.Replace(" ", "");


            var unreversedInput = cleanInput.ToCharArray();
            Array.Reverse(unreversedInput);
            string reversedInput = new string(unreversedInput);

            Console.WriteLine("your word/sentence forwards:" + cleanInput);
            Console.WriteLine("your word/sentence backwards:" + reversedInput);

            Console.WriteLine(cleanInput.Equals(reversedInput) == true ? "This word/sentence IS a palindrome" : "This word/sentence IS NOT a palindrome");

            Console.ReadKey();

        }
    }
}
