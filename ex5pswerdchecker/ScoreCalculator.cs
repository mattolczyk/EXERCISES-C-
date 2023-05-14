using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ex5pswerdchecker;

namespace ex5pswerdchecker
{
    public enum PasswordScore
    {
        Blank = 0,
        VeryWeak = 1,
        Weak = 2,
        Medium = 3,
        Strong = 4,
        VeryStrong = 5
    }


    public class ScoreCalculator
    {
        public PasswordScore CheckStrength(string password)
        {
            int score = 1;

            if (password.Length < 1)
            {
                Console.WriteLine("Please provide your password.");
                return PasswordScore.Blank;

            }
            if (password.Length < 4)
            {
                Console.WriteLine("Your password is too short - it should consist of at least 4 characters");
                return PasswordScore.VeryWeak;
                //return (PasswordScore)1;
            }
            
            if (password.Length >= 10)
            { score = score + 1; }
            if (Regex.Match(password, @"\d+", RegexOptions.ECMAScript).Success)
            { score = score + 1; }
            else Console.WriteLine("Suggestion: consider adding digits to your password.");
            if (Regex.Match(password, @"[a-z]", RegexOptions.ECMAScript).Success && Regex.Match(password, @"[A-Z]", RegexOptions.ECMAScript).Success)
            { score = score + 1; }
            else Console.WriteLine("Suggestion: consider using lowercase and uppercase characters in your password.");
            if (Regex.Match(password, @"[!,?,@,#,$,%,^,&,*]").Success)
            { score = score + 1; }
            else Console.WriteLine("Suggestion: consider adding special characters to your password. Eg. !@#$%^&*");

            return (PasswordScore)score;
        }
    }

}

