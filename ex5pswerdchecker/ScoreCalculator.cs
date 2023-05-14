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
        blank = 0,
        veryweak = 1,
        weak = 2,
        medium = 3,
        strong = 4,
        verystrong = 5
    }

    public class ScoreCalculator
        {
            public int  CheckStrength(string password)
            {
                int score = 1;

                if (password.Length < 1)
                    return 0;
                if (password.Length < 4)
                    return 1;

            if (password.Length >= 8)
            { score = score + 1; }
            if (password.Length >= 12)
            { score = score + 1; }
            if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
            { score = score + 1; }
            if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success && Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
            { score = score + 1; }
            if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
            { score = score + 1; }

            return score;
            }
        }

}

